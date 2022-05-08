using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    Canvas pauseCanvas;
    bool active;
    void Start()
    {
        pauseCanvas = GetComponent<Canvas>();
        pauseCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            active = !active;
            pauseCanvas.enabled = active;
            Time.timeScale = (active) ? 0 : 1f;
        }
    }

    public void Resume()
    {
        active = !active;
        pauseCanvas.enabled = active;
        Time.timeScale = (active) ? 0 : 1f;
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("lvl select");
    }
}
