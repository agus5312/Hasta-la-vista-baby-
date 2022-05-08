using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bebe : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            FindObjectOfType<GameOver>().GameOverActive();
        }

        if(collision.CompareTag("Win"))
        {
            FindObjectOfType<Win>().WinActive();
        }
    }

   

}
