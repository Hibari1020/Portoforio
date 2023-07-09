using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VContainer;
using VContainer.Unity;

public class PlayerInstantiate : MonoBehaviour
{
    [SerializeField]private GameObject Player;

    private IGameStatus _iGameStatus;

    [Inject]
    public void Inject(IGameStatus _iGameStatus){
        this._iGameStatus = _iGameStatus;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.UpdateAsObservable()
            .Where(_ => Input.GetKey(KeyCode.Space))
            .Where(_ => _iGameStatus.StartBool)
            .Take(1)
            .Subscribe(_ => Instantiate(Player));
    }

   
}
