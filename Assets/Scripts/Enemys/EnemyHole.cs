using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHole : MonoBehaviour
{
    public string otro;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(otro))
        { 
            Destroy(transform.parent.gameObject);
        }   
    }
}
