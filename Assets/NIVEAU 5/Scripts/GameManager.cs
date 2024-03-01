using UnityEngine;
using UnityEngine.UI;
namespace Niveau5
{
  public class GameManager : MonoBehaviour
  {
    public Player player;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;

    private int score;
    private bool isLevel5 = false;

    private void Awake()
    {
      Application.targetFrameRate = 60;
      Pause();
    }

    private void Update()
    {
      if (isLevel5)
      {
        return;
      }
    }

    public void Play()
    {
      score = 0;
      scoreText.text = score.ToString();
      playButton.SetActive(false);
      gameOver.SetActive(false);
      Time.timeScale = 1f;
      player.enabled = true;

      Pipes[] pipes = FindObjectsOfType<Pipes>();

      for (int i = 0; i < pipes.Length; i++)
      {
        Destroy(pipes[i].gameObject);
      }
    }

    public void Pause()
    {
      Time.timeScale = 0f;
      player.enabled = false;
    }

    public void GameOver()
    {
      gameOver.SetActive(true);
      playButton.SetActive(true);

      Pause();
    }

    public void InscreaseScore()
    {
      score++;
      scoreText.text = score.ToString();
    }

    public void SetLevel5()
        {
            isLevel5 = true;
        }
  }
}
