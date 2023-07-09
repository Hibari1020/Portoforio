using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VContainer;
using VContainer.Unity;
using Cysharp.Threading.Tasks;

public class RedCube5 : MonoBehaviour, IEvent
{
    [SerializeField]private Text _eventText;
    [SerializeField]private Text _moneyText;

    private IDiceManager _iDiceManager;
    private IMoneyManager _iMoneyManager;
    List<int> Number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

    [Inject]
    public void Inject(IDiceManager _iDiceManager, IMoneyManager _iMoneyManager){
        this._iDiceManager = _iDiceManager;
        this._iMoneyManager = _iMoneyManager;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Event(){
        _iDiceManager.OnClick = true;
        Debug.Log("RedCube衝突");

        MoneyEvent();
    }

    public void ExitEvent(){
        _iDiceManager.OnClick = false;
        Debug.Log("RedCubeExit");
    }

    private void MoneyEvent(){
        int RandomNumber = Random.Range(0, Number.Count);
        int randomIndex = Number[RandomNumber];
        Number.RemoveAt(RandomNumber);

        switch(randomIndex){
            case 1:
                _eventText.text = "VRアプリコンテストで優勝! HMDを手に入れる";
                _iMoneyManager.MoneyScore += 30000;
                break;
            
            case 2:
                _eventText.text = "VTuberアプリを作って一発当てる";
                _iMoneyManager.MoneyScore += 50000;
                break;
                
             case 3:
                _eventText.text = "VR空間で出会った人が恋人になる";
                _iMoneyManager.MoneyScore += 2000;
                break;

            case 4:
                _eventText.text = "ARのゲームを作って楽しい";
                _iMoneyManager.MoneyScore += 1000;
                break;

            case 5:
                _eventText.text = "VRゲームをつくって楽しい";
                _iMoneyManager.MoneyScore += 2000;
                break;
            
            case 6:
                _eventText.text = "メタバース宝くじに当たる";
                _iMoneyManager.MoneyScore += 20000;
                break;
            
            case 7:
                _eventText.text = "VRのスポーツ大会で優勝した";
                _iMoneyManager.MoneyScore += 10000;
                break;
             
             case 8:
                 _eventText.text = "自分が作った仮想空間が人気になる";
                 _iMoneyManager.MoneyScore += 50000;
                 break;
            
            case 9:
                 _eventText.text = "メタバースの会社に入る";
                 _iMoneyManager.MoneyScore += 1000;
                 break;
            
            case 10:
                 _eventText.text = "VR酔いをしない薬を開発する";
                _iMoneyManager.MoneyScore += 10000;
                 break;
        }
         _moneyText.text = _iMoneyManager.MoneyScore.ToString();
    }
}
