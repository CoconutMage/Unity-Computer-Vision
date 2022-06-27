using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeObstacle : MonoBehaviour
{
  float timer;
  void Start()
  {
    timer = 7.5f;
  }
  void Update()
  {
    if (timer <= 0)
    {
      Destroy(gameObject);
    }
    else
    {
      timer -= Time.deltaTime;
    }
  }
}
