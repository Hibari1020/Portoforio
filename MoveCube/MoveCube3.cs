using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VContainer;
using VContainer.Unity;

public class MoveCube3 : MonoBehaviour, IEvent
{
    [SerializeField] Text _eventText;
    private int _randomNumber;
    
    private IDiceManager _iDiceManager;

    [Inject]
    public void Inject(IDiceManager _iDiceManager){
        this._iDiceManager = _iDiceManager;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Event(){
        _iDiceManager.OnClick = false;
        Debug.Log("MoveCube衝突");

       Anim();
    }

    public void ExitEvent(){
        _iDiceManager.OnClick = false;
        Debug.Log("MoveCubeExit");
    }

    private void Anim(){
         while(_randomNumber == 0){
            _randomNumber = Random.Range(-3, 3);
        }

        var _playerAnim = GameObject.FindWithTag("Player").GetComponent<Animator>();
        _playerAnim.SetTrigger("Move" + _randomNumber);

        _eventText.text = _randomNumber.ToString() + "マス進む";
    }
}


