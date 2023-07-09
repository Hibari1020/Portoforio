using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer;
using VContainer.Unity;
using UniRx;
using UniRx.Triggers;
using UnityEngine.UI;

public class SetActive : MonoBehaviour
{
    [SerializeField]private Button _diceButton;
    [SerializeField]private Text _moneyText;
    [SerializeField]private Text _subMoneyText;
    [SerializeField]private Text _diceText;
    [SerializeField]private Button _restartButton;
    [SerializeField]private Text _gameNameText;
    [SerializeField]private Text _gameOverText;
    [SerializeField]private Text _gameClearText;
    [SerializeField]private Text _eventText;
    

    private IGameStatus _iGameStatus;

    [Inject]
    public void Inject(IGameStatus _iGameStatus){
        this._iGameStatus = _iGameStatus;
    }

    // Start is called before the first frame update
    public void Start()
    {
       

        this.UpdateAsObservable()
            .Where(_ => Input.GetKey(KeyCode.Space))
            .Where(_ => _iGameStatus.StartBool)
            .Subscribe(_ => 
            {
                _diceButton.gameObject.SetActive(true);
                _moneyText.gameObject.SetActive(true);
                _subMoneyText.gameObject.SetActive(true);
                _diceText.gameObject.SetActive(true);
                _eventText.gameObject.SetActive(true);
                _gameNameText.gameObject.SetActive(false);
                
            });

        this.UpdateAsObservable()
            .Where(_ => Input.GetKey(KeyCode.Space))
            .Where(_ => _iGameStatus.GameOver)
            .Subscribe(_ => 
            {
                _diceButton.gameObject.SetActive(false);
                _moneyText.gameObject.SetActive(false);
                _subMoneyText.gameObject.SetActive(false);
                _diceText.gameObject.SetActive(false);
                _eventText.gameObject.SetActive(false);
                _gameOverText.gameObject.SetActive(true);
                _restartButton.gameObject.SetActive(true);
            });

        this.UpdateAsObservable()
            .Where(_ => Input.GetKey(KeyCode.Space))
            .Where(_ => _iGameStatus.GameClear)
            .Subscribe(_ => 
            {
                _diceButton.gameObject.SetActive(false);
                _moneyText.gameObject.SetActive(false);
                _subMoneyText.gameObject.SetActive(false);
                _diceText.gameObject.SetActive(false);
                _eventText.gameObject.SetActive(false);
                _gameClearText.gameObject.SetActive(true);
                _restartButton.gameObject.SetActive(true);
            });        
    } 
}
