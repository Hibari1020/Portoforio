using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VContainer;
using VContainer.Unity;

public class GameStatus : MonoBehaviour, IGameStatus
{
    private bool _startBool = true;
    public bool StartBool{
        get { return _startBool;}
        set { _startBool = value;}
    }

    private bool _gameNow;
    public bool GameNow {
        get {return _gameNow;}
        set { _gameNow = value;}
    }
    
    private bool _gameOver;
    public bool GameOver{ 
        get { return _gameOver;}
        set { _gameOver = value;}
    }

    private bool _gameClear;
    public bool GameClear{
        get { return _gameClear; }
        set { _gameClear = value;}
    }

    
    void Start(){
         Debug.Log("StartBoolが"+ StartBool);
         Debug.Log("GameNowが"+ GameNow);

         this.UpdateAsObservable()
             .Where(_ => _startBool == true)
             .Where(_ => Input.GetKey(KeyCode.Space))
             .Subscribe(_ => ChangeGameNow());
    }
    

    public void ChangeGameOver(){
        _gameNow = false;
        _gameOver = true;

        Debug.Log("GameOver");
    }

    public void ChangeGameNow(){
        _startBool = false;
        _gameNow = true;
        Debug.Log("GameNow");
        Debug.Log("StartBoolが"+ StartBool);
        Debug.Log("GameNowが"+ GameNow);
    }

    public void ChangeGameClear(){
        _gameNow = false;
        _gameClear = true;
        Debug.Log("ゲームクリア");
    }
    
}
