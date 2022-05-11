    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCam : MonoBehaviour
{
    public GameObject[] wayPoints;
    public float vel;
    int lvl;

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
        //transform.position = wayPoints[lvl].transform.position;
        transform.LookAt(wayPoints[lvl].transform.position);
        transform.position += transform.forward * vel * Time.deltaTime;
    }

}
