using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float restartDelay = 2f;
    public GameObject gameOver;
    bool gameHasEnded = false;

    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            gameOver.SetActive(true);
            // Restart Game
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

}
