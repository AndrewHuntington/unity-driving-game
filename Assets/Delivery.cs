using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

  [SerializeField] float destroyDelay = 0.5f;
  bool hasPackage;

  void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log("Collided");
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Package" && !hasPackage)
    {
      hasPackage = true;
      Destroy(other.gameObject, destroyDelay);
    }

    if (other.tag == "Customer" && hasPackage)
    {
      Debug.Log("Delivered package");
      hasPackage = false;
    }
  }
}
