using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFallObject : MonoBehaviour
{
    public float speedToMove;
    public float restScale;
    public float smallScale;
    public float originalScale;
    Vector3 positionToFall;
    public ActivateFall activeFallScript;
    public bool isGrabbing;
    public bool realease;
    bool active;

    public GameObject placeToFall;
    public GameObject objectToKillBaby;
    void Start()
    {
        isGrabbing = false;
        realease = false;
        originalScale = 1;
        objectToKillBaby.SetActive(false);
    }

    void Update()
    {
        active = activeFallScript.active;

        transform.localScale = new Vector3(originalScale, originalScale, originalScale);


        if (active && originalScale > smallScale && !isGrabbing)
        {
            originalScale = originalScale - restScale * Time.deltaTime;

            positionToFall = placeToFall.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, positionToFall, speedToMove*Time.deltaTime);
        }

        if(realease && originalScale > smallScale)
        {
            originalScale = originalScale - restScale * Time.deltaTime;

            positionToFall = placeToFall.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, positionToFall, speedToMove * Time.deltaTime);
        }

            

        if (originalScale <= smallScale)
            objectToKillBaby.SetActive(true);
    
    }

    public void OnMouseDrag()
    {
        isGrabbing = true;
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(pos.x, pos.y, 0);
    }

   public void OnMouseUp()
    {
        isGrabbing = false;
        realease = true;
    }

}
