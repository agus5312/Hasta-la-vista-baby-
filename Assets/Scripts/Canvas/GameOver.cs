using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    Canvas gameOverCanvas;
    void Start()
    {
        gameOverCanvas = GetComponent<Canvas>();
        gameOverCanvas.enabled = false;
    }

    
    public void GameOverActive()
    {
        gameOverCanvas.enabled = true;
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
