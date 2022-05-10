using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : MonoBehaviour
{
    public int vueltasNecesarias;
    int contador;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Cinta"))
        {
            contador ++;
            if (contador >= vueltasNecesarias)
            {
                Destroy(transform.parent.gameObject);
            }
        }
    }
    
}
