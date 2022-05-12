using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable3 : MonoBehaviour
{
        public GameObject[] cablePelado;
        public float limitecable;
        public SpriteRenderer finalCable;
    public GameObject origen;
    public GameObject cablesito;


        private void Start()
        {
        ActualizarTamaño();
        }

        private void OnMouseDrag()
        {
            ActualizarPosicion();
            ActualizarRotacion();
            ActualizarTamaño();
        }

        void ActualizarPosicion()
        {
            if (finalCable.size.x < limitecable)
            {

                Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = new Vector3(pos.x, pos.y, 0);
            }
        }

        void ActualizarRotacion()
        {
            Vector2 posicionActual = transform.position;
            Vector2 puntoOrigen = origen.transform.position;

            Vector2 direccion = posicionActual - puntoOrigen;

            float angulo = Vector2.SignedAngle(Vector2.left * transform.lossyScale, direccion);
            transform.rotation = Quaternion.Euler(0, 0, angulo);
            cablesito.transform.rotation= Quaternion.Euler(0, 0, angulo +180);
    }

        void ActualizarTamaño()
        {
            Vector2 posicionActual = transform.position;
            Vector2 puntoOrigen = origen.transform.position;

            float distancia = Vector2.Distance(posicionActual, puntoOrigen);
            finalCable.size = new Vector2(distancia, finalCable.size.y);
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.CompareTag("Toma"))
            {
                for (int i = 0; i < cablePelado.Length; i++)
                {
                    Destroy(cablePelado[i]);
                }
            }
        }
    
}
