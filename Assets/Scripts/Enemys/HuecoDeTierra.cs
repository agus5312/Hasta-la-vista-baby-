using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuecoDeTierra : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pala"))
        {
            Destroy(gameObject, 0.1f);
        }
            
    }
}
