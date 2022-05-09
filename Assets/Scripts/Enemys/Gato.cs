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
            mirarBebe = false;
            transform.up = wayPoints[posicion].transform.position - transform.position;
            transform.position += transform.up * vel * Time.deltaTime;

            if(transform.position == wayPoints[posicion].transform.position)
            {
                canMove = false;
                mirarBebe = true;
                posicion++;
            }
        }
    }
    private void OnMouseDown()
    {
        clicksActuales--;
        if (!canMove)
        {
            Instantiate(pelos, gameObject.transform);
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
}
