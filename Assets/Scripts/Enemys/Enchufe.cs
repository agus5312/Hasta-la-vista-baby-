using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enchufe : MonoBehaviour
{
    public GameObject PartePeligrosa;
    public GameObject Chispas;
    Component colider;
    public float limitecable;
    private void Start()
    {
        colider = PartePeligrosa.GetComponent<BoxCollider2D>();
    }
    //private void OnMouseDown()
    //{
    //    Component.Destroy(colider);
    //    Chispas.SetActive(false);
    //}

    public SpriteRenderer finalCable;

    
    private void OnMouseDrag()
    {
        ActualizarPosicion();
        ActualizarRotacion();
        ActualizarTama�o();
    }

    void ActualizarPosicion()
    {
        if(finalCable.size.x < limitecable) 
        {

            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(pos.x, pos.y, 0);
        }
    }

    void ActualizarRotacion()
    {
        Vector2 posicionActual = transform.position;
        Vector2 puntoOrigen = transform.parent.position;

        Vector2 direccion = posicionActual - puntoOrigen;

        float angulo = Vector2.SignedAngle(Vector2.left * transform.lossyScale, direccion);
        transform.rotation = Quaternion.Euler(0, 0, angulo);
    }

    void ActualizarTama�o()
    {
        Vector2 posicionActual = transform.position;
        Vector2 puntoOrigen = transform.parent.position;

        float distancia = Vector2.Distance(posicionActual, puntoOrigen);
        finalCable.size = new Vector2(distancia, finalCable.size.y);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Toma"))
        {
            Component.Destroy(colider);
            Chispas.SetActive(false);
        }
    }
}