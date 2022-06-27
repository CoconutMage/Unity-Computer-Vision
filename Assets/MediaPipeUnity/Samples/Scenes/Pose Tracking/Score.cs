using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
  int score;
  [SerializeField]
  TextMeshProUGUI scoreText;
  [SerializeField]
  TextMeshProUGUI finalScoreText;
  [SerializeField]
  GameObject button;
  void Start()
  {
    score = 0;
  }
  void Update()
  {

  }
  public void Respawn()
  {
    Application.Quit(0);
  }
  public void Died()
  {
    scoreText.enabled = false;
    finalScoreText.enabled = true;
    finalScoreText.text = "You Lose\n Final Score: " + score;
    button.SetActive(true);
  }
  public void Scored()
  {
    score += 1;
    scoreText.text = "Obstacles Destroyed: " + score;
  }
}
