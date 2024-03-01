using UnityEngine;
using UnityEngine.UI;
namespace Niveau3
{
     public class GameManager : MonoBehaviour
     {
          public Player player;
          public Text scoreText;
          public GameObject playButton;
          public GameObject gameOver;
          public Button level4Button;

          private int score;

          private void Awake()
          {
               Application.targetFrameRate = 60;
               Pause();
               level4Button.gameObject.SetActive(false);
          }

          private void Update()
        {
            
            if (score >= 8)
            {
                level4Button.gameObject.SetActive(true);
                Pause();
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

          public void IncreaseScore()
          {
               score++;
               scoreText.text = score.ToString();
          }

          public void LoadLevel4()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("LEVEL04");
        }
     }
}
