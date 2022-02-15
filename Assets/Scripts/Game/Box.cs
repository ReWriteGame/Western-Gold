using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Box : MonoBehaviour
{

 public UnityEvent takeGoldEvent;
 public UnityEvent takeStoneEvent;
 private void OnCollisionEnter2D(Collision2D other)
 {
  if (other.gameObject.GetComponent<Gold>())
   takeGoldEvent?.Invoke();
  
  if (other.gameObject.GetComponent<Stone>())
   takeStoneEvent?.Invoke();
 }


}
