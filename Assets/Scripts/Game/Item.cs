using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
   public UnityEvent openEvent;


   private void OnCollisionEnter2D(Collision2D other)
   {
      if(other.gameObject.GetComponent<Box>())
         openEvent?.Invoke();
   }
}
