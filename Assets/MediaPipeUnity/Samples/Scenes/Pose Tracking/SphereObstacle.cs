using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereObstacle : MonoBehaviour
{
  void Start()
  {
    
  }
  void FixedUpdate()
  {
    transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
  }
}
