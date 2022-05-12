using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHole : MonoBehaviour
{
    public string otro;
    public GameObject tablon;

    private void Awake()
    {
        tablon.SetActive(false);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(otro))
        {
            tablon.SetActive(true);
            Destroy(transform.parent.gameObject,0.1f*Time.deltaTime);
        }   
    }
}
