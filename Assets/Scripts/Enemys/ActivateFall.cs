using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFall : MonoBehaviour
{
    public bool active;

    public void Start()
    {
        active = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            active = true;
    }

}
