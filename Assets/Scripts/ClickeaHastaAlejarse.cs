using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickeaHastaAlejarse : MonoBehaviour
{
    public float velX;
    public float VelY;
    bool cooldown = false;
    float time = 0;
    Rigidbody2D RB2D;
    public int restante = 5;

    

    private void Start()
    {
        RB2D = gameObject.GetComponent<Rigidbody2D>();
    }
    private void OnMouseDown()
    {
        restante -= 1;
        if (restante <= 0)
        {
            RB2D.velocity = new Vector2(velX, VelY);
            cooldown = true;
            time = 0;
            restante = 5;
        }
    }

    private void Update()
    {
        if (cooldown == true)
        {
            time += Time.deltaTime;

            if (time > 1f)
            {
                RB2D.velocity = new Vector2(0, 0);
                velX = velX * -1;
                VelY = VelY * -1;
                cooldown = false;
            }

        }
    }

   

}
