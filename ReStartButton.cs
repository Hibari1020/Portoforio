using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;
using UnityEngine.SceneManagement;

public class ReStartButton : MonoBehaviour
{
    [SerializeField]private Button _restartButton;

    // Start is called before the first frame update
    void Start()
    {
        _restartButton.OnClickAsObservable()
                      .Subscribe(_ => SceneManager.LoadScene("StageScene"))
                      .AddTo(this);
                      
    }

   
}
