using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    Canvas gameOverCanvas;
    bool active;
    void Start()
    {
        gameOverCanvas = GetComponent<Canvas>();
        gameOverCanvas.enabled = false;
        Time.timeScale = 1f;
    }

    
    public void GameOverActive()
    {

        gameOverCanvas.enabled = true;
        active = !active;
        Time.timeScale = (active) ? 0 : 1f;
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
