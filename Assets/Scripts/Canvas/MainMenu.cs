using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Canvas optionsCanvas;
    public Canvas creditsCanvas;

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
    public void Start()
    {
        optionsCanvas.enabled = false;
        creditsCanvas.enabled = false;
    }
    public void Play()
    {
        SceneManager.LoadScene("Seleccion de nivel");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Options()
    {
        optionsCanvas.enabled = true;
    }

    public void Credits()
    {
        creditsCanvas.enabled = true;
    }
}
