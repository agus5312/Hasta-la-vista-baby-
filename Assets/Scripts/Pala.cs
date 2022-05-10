using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pala : MonoBehaviour
{
    public GameObject palaConTierra;
    public GameObject palaSinTierra;
    
    void Start()
    {
        palaConTierra.SetActive(false);
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Tierra"))
        {
            palaConTierra.SetActive(true);
            palaSinTierra.SetActive(false);
        }

        if (collision.CompareTag("Hole"))
        {
            palaConTierra.SetActive(false);
            palaSinTierra.SetActive(true);
        }

    }
}
