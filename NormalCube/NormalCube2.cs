using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VContainer;
using VContainer.Unity;

public class NormalCube2 : MonoBehaviour, IEvent
{
    [SerializeField]private Text _eventText;
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
        _iDiceManager.OnClick = true;
        Debug.Log("NormalCube衝突");


        _eventText.text = "ノーマルマスです";
    }

    public void ExitEvent(){
        _iDiceManager.OnClick = false;
        Debug.Log("NormalCubeExit");
    }
}
