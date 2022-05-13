using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winwin : MonoBehaviour
{
    public GameObject win;
    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("player"))
        {
            win.SetActive(true);
        }
    }
}
