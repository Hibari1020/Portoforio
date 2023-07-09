using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void OnCollisionEnter(Collision other){
       var _event = other.gameObject.GetComponent<IEvent>();
       _event.Event();
   }

   public void OnCollisionExit(Collision other){
    var _event = other.gameObject.GetComponent<IEvent>();
    _event.ExitEvent();
   }
}
