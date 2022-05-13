using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject botonprev;
    public GameObject botonnext;
    public string [] niveles;
    public string[] nombresNivel;
    int i;
    public Text nombre;
    private void Start()
    {
        botonprev.SetActive(false);
        i = 0;
        nombre.text = nombresNivel[i];
    }
    public void Play()
    {
        SceneManager.LoadScene(niveles[i]);
    }

    public void Next()
    {
        if (i == niveles.Length - 2)
        {
            botonnext.SetActive(false);
        }
        if (i == 0)
        {
            botonprev.SetActive(true);
        }
        i++;
            nombre.text = nombresNivel[i];
        
    }

    public void Previous()
    {
        if (i == niveles.Length -1)
        {
            botonnext.SetActive(true);
        }
        if (i == 1)
        {
            botonprev.SetActive(false);
        }

        i--;
            nombre.text = nombresNivel[i];
        
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
