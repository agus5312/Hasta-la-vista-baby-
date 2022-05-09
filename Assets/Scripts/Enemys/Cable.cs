using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : MonoBehaviour
{
    BoxCollider2D colision;
    SpriteRenderer spray;
    public Sprite nuevo;
    
    public GameObject electricidad;
    int contador;

    private void Start()
    {
        colision = GetComponent<BoxCollider2D>();
        spray = GetComponent<SpriteRenderer>();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Cinta"))
        {
            contador += 1;
            if (contador >= 5)
            {
                electricidad.SetActive(false);
                Component.Destroy(colision);
                
                spray.sprite = nuevo;
            }
        }
    }
    
}