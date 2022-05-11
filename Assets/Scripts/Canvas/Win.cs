using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    Canvas winCanvas;
    void Start()
    {
        winCanvas = GetComponent<Canvas>();
        winCanvas.enabled = false;
    }

   public void WinActive()
    {
        winCanvas.enabled = true;
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
