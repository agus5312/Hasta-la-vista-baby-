using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempoInicial : MonoBehaviour
{
    public GameObject Objetos;
    public GameObject Falsos;

    float time = 0;
    private void Awake()
    {
        Objetos.SetActive(false);

        Falsos.SetActive(true);
        
    }

    private void Update()
    {
        time += Time.deltaTime;
        if (time > 5f)
        {
            Activar();
        }
    }

    void Activar()
    {
            Objetos.SetActive(true);
            Falsos.SetActive(false);
    }
}
