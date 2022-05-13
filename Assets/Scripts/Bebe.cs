using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bebe : MonoBehaviour
{
    bool isDead;
    public AudioSource soundChanel;
    public AudioClip risas;

    public float timer;
    public float randomN;
    public float randomP;
    private void Start()
    {
        soundChanel.clip = risas;
        isDead = false;
        timer = 1f;
    }

    private void Update()
    {
        if (!isDead)
        {
            if (timer >= 0)
                timer -= Time.deltaTime;
            if(timer <= 0)
            {
                soundChanel.Play();
                timer = Random.Range(randomN, randomP);
            }
                
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            isDead = true;
            FindObjectOfType<GameOver>().GameOverActive();
        }

        if(collision.CompareTag("Win"))
        {
            FindObjectOfType<Win>().WinActive();
        }
    }

   

}
