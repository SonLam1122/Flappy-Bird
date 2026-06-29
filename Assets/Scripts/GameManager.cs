using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject startPanel;

    public GameObject gameOverUI;

    void Start(){

        // dung game luc moi vao
        Time.timeScale = 0f;

        startPanel.SetActive(true);
        gameOverUI.SetActive(false);
    }

    public void StartGame(){

        startPanel.SetActive(false);

        // cho phep game chay
        Time.timeScale = 1f;
    }

    public void RestartGame(){

        Time.timeScale = 1f;

        // tai lai scene hien tai
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
