using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pala : MonoBehaviour
{
    public GameObject palaConTierra;
    public GameObject palaSinTierra;
    float timer;
    bool active;
    bool with;


    public AudioSource soundChanel;
    public AudioClip takeSand;
    public AudioClip putSand;

    void Start()
    {
        palaConTierra.SetActive(false);
        active = false;
    }

    
    void Update()
    {

        if(active)
        {
            timer -= Time.deltaTime;

            if(timer <= 0)
            {
                soundChanel.clip = putSand;
                soundChanel.Play();
                palaConTierra.SetActive(false);
                palaSinTierra.SetActive(true);
                active = false;
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Tierra"))
        {
            soundChanel.clip = takeSand;
            soundChanel.Play();
            palaConTierra.SetActive(true);
            palaSinTierra.SetActive(false);
        }

        if (collision.CompareTag("Hole"))
        {
            active = true;
            timer = 0.2f;
        }

    }
}
