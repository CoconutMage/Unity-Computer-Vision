using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereObstacle : MonoBehaviour
{
  float speed = 0.3f;
  void Start()
  {
    
  }
  void FixedUpdate()
  {
    if (transform.position.x < GameObject.Find("PoseWorldLandmarks Annotation").transform.position.x) transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
    else transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
  }
  private void OnDestroy()
  {
    GameObject.Find("Canvas").GetComponent<Score>().Scored();
  }
}
