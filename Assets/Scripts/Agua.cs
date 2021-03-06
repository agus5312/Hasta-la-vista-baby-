using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agua : MonoBehaviour
{
    int limpieza = 5;
    SpriteRenderer sprite;

    public AudioSource soundChanel;
    public AudioClip trapo;
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        soundChanel.clip = trapo;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Trapo")
        {
            soundChanel.Play();
            limpieza -= 1;
            sprite.color = new Color(1f, 1f, 1f, sprite.color.a - 0.2f);
            if (limpieza <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
