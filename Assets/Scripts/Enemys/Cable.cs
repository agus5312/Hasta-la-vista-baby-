using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : MonoBehaviour
{
    BoxCollider2D colision;
    SpriteRenderer spray;
    public Sprite nuevo;
    GameObject Cinta;
    public GameObject electricidad;

    private void Start()
    {
        colision = GetComponent<BoxCollider2D>();
        spray = GetComponent<SpriteRenderer>();
        Cinta = GameObject.FindGameObjectWithTag("Cinta");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Cinta"))
        {
            electricidad.SetActive(false);
            Component.Destroy(colision);
            Cinta.SetActive(false);
            spray.sprite = nuevo;
        }
    }
    
}
