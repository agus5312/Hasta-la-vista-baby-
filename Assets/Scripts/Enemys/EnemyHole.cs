using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHole : MonoBehaviour
{
    public GameObject plankRemplaceObject;
    public GameObject holeObject;

    public void Start()
    {
        plankRemplaceObject.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Plank"))
        {
            plankRemplaceObject.SetActive(true);
            Destroy(holeObject, 0.3f * Time.deltaTime);
        }
            
    }
}
