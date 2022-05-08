using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovAspiradora : MonoBehaviour
{
    public float speed = 2;
    bool moverse = true;
    private void Update()
    {
       if (moverse == true)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.Rotate(Vector3.forward * 120 * Time.deltaTime);
        moverse = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        transform.Rotate(Vector3.forward * 120 * Time.deltaTime);
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        moverse = true;
    }

    //Rigidbody2D RBD2;
    //float tiempo;
    //int cooldown;
    //private void Start()
    //{
    //    RBD2 = GetComponent<Rigidbody2D>();
    //    RBD2.velocity = new Vector2(2, 2);
    //    cooldown = 4;
    //}

    //void cambiarDireccion()
    //{
    //    int direccionX = Random.Range(0, 2);
    //    int direccionY = Random.Range(0, 2);
    //    if (direccionX == 1)
    //    {
    //        RBD2.velocity = new Vector2(RBD2.velocity.x * -1, RBD2.velocity.y);
    //    }

    //    if (direccionY == 1)
    //    {
    //        RBD2.velocity = new Vector2(RBD2.velocity.x, RBD2.velocity.y * -1);
    //    }

    //}
    //void Update()
    //{
    //    tiempo += Time.deltaTime;

    //    if (tiempo > cooldown)
    //    {
    //        cooldown = Random.Range(3, 5);
    //        cambiarDireccion();
    //        tiempo = 0;
    //    }
    //}

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.tag == "ParedHorizontal")
    //    {
    //        RBD2.velocity = new Vector2(RBD2.velocity.x * -1, RBD2.velocity.y);
    //    }
    //    if (collision.tag == "ParedVertical")
    //    {
    //        RBD2.velocity = new Vector2(RBD2.velocity.x, RBD2.velocity.y * -1);
    //    }
    //}

    private void OnMouseDrag()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(pos.x, pos.y, 0);
    }
}
