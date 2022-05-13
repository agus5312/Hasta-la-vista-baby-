using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    Canvas winCanvas;
    bool active;
    void Start()
    {
        winCanvas = GetComponent<Canvas>();
        winCanvas.enabled = false;
        Time.timeScale = 1f;
    }

   public void WinActive()
    {
        winCanvas.enabled = true;
        active = !active;
        Time.timeScale = (active) ? 0 : 1f;
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
