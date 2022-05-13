using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gato : MonoBehaviour
{
    public GameObject[] wayPoints;
    public GameObject pelos;
    public GameObject bebe;
    public float vel;
    public int clicksMax = 5;
    int clicksActuales;
    int posicion = 1;
    bool canMove = false;
    bool mirarBebe = true;


    [SerializeField] Animator anim;
    public AudioSource soundChanel;
    public AudioClip maullido;
    public AudioClip attack;

    private void Start()
    {
        clicksActuales = clicksMax;
    }
    private void Update()
    {
        if (mirarBebe)
        {
            transform.up = bebe.transform.position - transform.position;
        }
        if (canMove)
        {
            anim.SetBool("isWalking", true);
            mirarBebe = false;
            transform.up = wayPoints[posicion].transform.position - transform.position;
            transform.position += transform.up * vel * Time.deltaTime;

            if (Vector2.Distance(transform.position, wayPoints[posicion].transform.position) <= 0.5f)
            {
                canMove = false;
                mirarBebe = true;
                posicion++;
            }
        }

        if(!canMove)
            anim.SetBool("isWalking", false);
    }
    private void OnMouseDown()
    {
        clicksActuales--;
        if (!canMove)
        {
            Instantiate(pelos, gameObject.transform);
            soundChanel.clip = maullido;
            soundChanel.Play();
        }
        if (posicion == wayPoints.Length)
        {
            posicion = 0;
        }
        if (clicksActuales <= 0)
        {
            canMove = true;
            clicksActuales = clicksMax;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            soundChanel.clip = attack;
            soundChanel.Play();
        }
    }
}
