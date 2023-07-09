using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class StartCube : MonoBehaviour, IEvent
{
    private IDiceManager _iDiceManager;
    
    [Inject]
    public void Inject(IDiceManager _iDiceManager){
        this._iDiceManager = _iDiceManager;
    }

   

    public void Event(){
        Debug.Log("StartCube衝突");
        _iDiceManager.OnClick = true;
    }

    public void ExitEvent(){
        Debug.Log("StartCubeExit");
        _iDiceManager.OnClick = false;
    }
}
