using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrulla : MonoBehaviour
{
    GameObject babyObject;
    public float speedTransform;
    public float speedRotation;
    public Transform[] wayPoints;
    public int index;
    void Start()
    {
        index = 0;
    }

    void Update()
    {
        
    }

    public void WayPoints()
    {

        if (wayPoints[index].position != transform.position)
        {
            //transform.up = wayPoints.Length - transform.position;
            //transform.position = new Vector3(transform.position.x, transform.position.y, 0);
            transform.position = Vector3.MoveTowards(transform.position, wayPoints[index].transform.position, speedTransform * Time.deltaTime);
        }

        else
        {
            if (index < wayPoints.Length - 1)
                index++;
            else
                index = 0;
        }

    }
}
