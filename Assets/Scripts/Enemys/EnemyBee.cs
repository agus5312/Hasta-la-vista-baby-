using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBee : MonoBehaviour
{
    GameObject babyObject;
    Vector3 position;

    public float visionRange;
    public float speed;


    void Start()
    {
        babyObject = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {

        FollowBaby();
        transform.up = babyObject.transform.position - transform.position;
        transform.position = new Vector3 (transform.position.x, transform.position.y,0);


    }

    public void FollowBaby()
    {
        Vector3 target = position;

        float distance = Vector3.Distance(babyObject.transform.position, transform.position);

        if (distance < visionRange)
            target = babyObject.transform.position;

        float velocidad = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, velocidad);
    }

    private void OnMouseDrag()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(pos.x, pos.y, 0);
    }

}
