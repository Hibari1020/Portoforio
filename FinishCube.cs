using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VContainer;
using VContainer.Unity;

public class FinishCube : MonoBehaviour, IEvent
{
    [SerializeField]private Text _eventText;
    private IDiceManager _iDiceManager;
    private IGameStatus _iGameStatus;

    [Inject]
    public void Inject(IDiceManager _iDiceManager, IGameStatus _iGameStatus){
        this._iDiceManager = _iDiceManager;
        this._iGameStatus = _iGameStatus;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void Event(){
       _iDiceManager.OnClick = false;
       _iGameStatus.ChangeGameClear();
       _eventText.text = "お疲れ様でした!スペースキーを押してください!";
   }

   public void ExitEvent(){
      Debug.Log("Exit");
   }
}
