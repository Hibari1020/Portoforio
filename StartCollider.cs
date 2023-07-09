using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StartCollider : MonoBehaviour, IEvent
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Event(){
      Debug.Log("StartCollider衝突");
      var _animator = GameObject.FindWithTag("Player").GetComponent<Animator>();
      _animator.Play("MoveCancel");
    }

    public void ExitEvent(){
       Debug.Log("StartColliderExit");
    }
}
