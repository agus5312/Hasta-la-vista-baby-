using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enchufe : MonoBehaviour
{
    public GameObject PartePeligrosa;
    public GameObject Chispas;
    Component colider;
    private void Start()
    {
        colider = PartePeligrosa.GetComponent<BoxCollider2D>();
    }
    private void OnMouseDown()
    {
        Component.Destroy(colider);
        Chispas.SetActive(false);
    }
}
