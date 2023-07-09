using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;
using VContainer;
using VContainer.Unity;


public class DiceButton : MonoBehaviour
{
    [SerializeField]private Button _diceButton;
    [SerializeField]private Text _diceText;
    private int _randomNumber;
    private IDiceManager _iDiceManager;

    [Inject]
    public void Inject(IDiceManager _iDiceManager){
        this._iDiceManager = _iDiceManager;
    }

    // Start is called before the first frame update
    public void Start()
    {
       _diceButton.OnClickAsObservable()
            .Where(_ => _iDiceManager.OnClick == true)
            .Subscribe(_ => ClickEvent());
          

       
    }

    private void ClickEvent(){
        _iDiceManager.OnClick = false;
        
        _randomNumber = Random.Range(1, 6);
        Debug.Log("クリック"+ _randomNumber);
        
        var _randomText = _randomNumber.ToString();
        _diceText.text = _randomText;

        var _animator = GameObject.FindWithTag("Player").GetComponent<Animator>();
         
        _animator.SetTrigger("Move" + _randomNumber);
        
    }

   
}
