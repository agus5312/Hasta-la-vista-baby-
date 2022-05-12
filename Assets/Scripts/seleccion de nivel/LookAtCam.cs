    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCam : MonoBehaviour
{
    public GameObject[] wayPoints;
    public float vel;
    int lvl = 0;
    bool move = false;
    private void Update()
    {
        if (move)
        {
            transform.LookAt(wayPoints[lvl].transform.position);
            transform.position += transform.forward * vel * Time.deltaTime;
            if (Vector3.Distance(transform.position, wayPoints[lvl].transform.position) <= 0.5f)
            {
                move = false;
            }
        }
    }

    public void CambioLvl(bool mOM)
    {
        if (mOM)
        {
            lvl++;
        }
        else
        {
            lvl--;
        }
        move = true;
    }
}
