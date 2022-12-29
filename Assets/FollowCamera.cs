using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
  [SerializeField] GameObject thingToFollow;

  // Using LateUpdate to control the camera movement helps prevent camera jitter
  void LateUpdate()
  {
    transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
  }
}
