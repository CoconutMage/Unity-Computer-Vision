using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
  [SerializeField]
  GameObject orb;
  [SerializeField]
  GameObject cone;
  float timer;
  [SerializeField]
  public Transform[] coneSpawns;
  [SerializeField]
  public Transform[] orbSpawns;
  public void Start()
  {
    timer = 5;
  }
  public void Update()
  {
    if (timer <= 0)
    {
      Debug.Log("Obstacle");
      SpawnObstacle();
      timer = 5;
    }
    else
    {
      timer -= Time.deltaTime;
    }
  }
  void SpawnObstacle()
  {
    if(Random.Range(0, 2) == 0)
    {
      Instantiate(orb, orbSpawns[Random.Range(0, orbSpawns.Length)].position, new Quaternion());
    }
    else
    {
      Instantiate(cone, coneSpawns[Random.Range(0, coneSpawns.Length)].position, new Quaternion());
    }
  }
}
