using UnityEngine;
using UnityEngine.UI;

namespace Niveau1
{
    public class GameManager : MonoBehaviour
    {
        public Player player;
        public Text scoreText;
        public GameObject playButton;
        public GameObject gameOver;
        public Button level2Button;

        private int score;

        private void Awake()
        {
            Application.targetFrameRate = 60;
            Pause();
            level2Button.gameObject.SetActive(false);
        }

        private void Update()
        {
            if (score >= 10)
            {
                level2Button.gameObject.SetActive(true);
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
            Aliens[] aliens = FindObjectsOfType<Aliens>();
            for (int i = 0; i < aliens.Length; i++)
            {
                Destroy(aliens[i].gameObject);
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


        public void LoadLevel2()
        {

            UnityEngine.SceneManagement.SceneManager.LoadScene("LEVEL02");
        }
    }
}