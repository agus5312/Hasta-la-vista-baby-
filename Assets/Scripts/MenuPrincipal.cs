using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour
{
    public string [] niveles;
    public string[] nombresNivel;
    int i;
    public Text nombre;
    private void Start()
    {
        i = 0;
        nombre.text = nombresNivel[i];
    }
    public void Play()
    {
        SceneManager.LoadScene(niveles[i]);
    }

    public void Next()
    {
        if(i != niveles.Length -1)
        {
            i++;
            nombre.text = nombresNivel[i];
        }
    }

    public void Previous()
    {
        if(i != 0)
        {
            i--;
            nombre.text = nombresNivel[i];
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
