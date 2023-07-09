using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer;
using VContainer.Unity;
using UniRx;
using UniRx.Triggers;

public class MoneyNothing : MonoBehaviour
{
    private IGameStatus _iGameStatus;
    private IMoneyManager _iMoneyManager;
    private IDiceManager _iDiceManager;

    [Inject]
    public void Inject(IGameStatus _iGameStatus, IMoneyManager _iMoneyManager, IDiceManager _iDiceManager){
        this._iGameStatus = _iGameStatus;
        this._iMoneyManager = _iMoneyManager;
        this._iDiceManager = _iDiceManager;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.UpdateAsObservable()
            .Where(_ => _iMoneyManager.MoneyScore < 0)
            .Subscribe(_ => 
            {
               _iGameStatus.ChangeGameOver();
               _iDiceManager.OnClick = false;
            });
    }

  
}
