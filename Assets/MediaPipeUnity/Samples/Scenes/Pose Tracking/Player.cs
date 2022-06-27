using UnityEngine;

public class Player : MonoBehaviour
{
  public void Start()
  {

  }
  public void Update()
  {

  }
  public void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Obstacle") Debug.Log(other.name);
  }
}
