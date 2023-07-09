using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;

public class DiceManager : IDiceManager
{
    private bool _onClick = true;
    public bool OnClick {
        get { return _onClick; }
        set { _onClick = value; }
    }
    
   
}
