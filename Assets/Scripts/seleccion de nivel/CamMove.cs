using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamMove : MonoBehaviour
{
    public CinemachineVirtualCamera cam;
    CinemachineTrackedDolly cinMac;
    public float vel;
    float velM;
    int lvl;
    bool canMove = false;

    private void Start()
    {
        cinMac = cam.GetCinemachineComponent<CinemachineTrackedDolly>();
        velM = vel;
    }
    private void Update()
    {
        if (canMove)
        {
            if(cinMac.m_PathPosition < lvl)
            {
                cinMac.m_PathPosition += velM * Time.deltaTime;
            }
            if(cinMac.m_PathPosition > lvl)
            {
                cinMac.m_PathPosition -= velM * Time.deltaTime;
            }
        }
        if(cinMac.m_PathPosition == lvl)
        {
            canMove = false;
            velM = vel;
        }
    }
    public void Nivel(bool mOM)
    {
        if (mOM)
        {
            lvl++;
            if (lvl == 1 || lvl == 3 || lvl == 6)
            {
                lvl++;
                velM = vel * 2;
            }
        }
        else
        {
            lvl--;
            if (lvl == 1 || lvl == 3 || lvl == 6)
            {
                lvl--;
                velM = vel * 2;
            }
        }
        canMove = true;
    }
}
