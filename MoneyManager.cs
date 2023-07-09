using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoneyManager : MonoBehaviour, IMoneyManager
{
    [SerializeField]private Text _moneyText;

    private int _moneyScore;
    public int MoneyScore {
        get { return _moneyScore;}
        set {_moneyScore = value;}
    }

  

    // Start is called before the first frame update
    void Start()
    {
     
       _moneyText.text = _moneyScore.ToString();

       
    }

   
}
