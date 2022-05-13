using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : MonoBehaviour
{
    public int vueltasNecesarias;
    int contador;
    public AudioSource soundChanel;
    public AudioClip cinta;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Cinta"))
        {
            soundChanel.clip = cinta;
            soundChanel.Play();

            contador ++;
            if (contador >= vueltasNecesarias)
            {
                Destroy(transform.parent.gameObject,0.3f);;
            }
        }
    }
    
}
