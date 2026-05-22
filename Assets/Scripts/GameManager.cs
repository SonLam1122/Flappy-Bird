using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject startPanel;

    public GameObject gameOverUI;

    void Start()
    {
        // Pause game lúc mới vào
        Time.timeScale = 0f;

        startPanel.SetActive(true);

        gameOverUI.SetActive(false);
    }

    // START GAME
    public void StartGame()
    {
        startPanel.SetActive(false);

        Time.timeScale = 1f;
    }

    // RESTART GAME
    public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex);
    }
}