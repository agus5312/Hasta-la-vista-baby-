using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse1 : MonoBehaviour
{
    public Texture2D[] cursor;
    public AudioSource soundChanel;
    public AudioClip soundGrab;
    public AudioClip soundLeave;

    private void Start()
    {
        Cursor.SetCursor(cursor[0], new Vector2(10, 10), CursorMode.Auto);

    }
    void Update()
    {
       if (Input.GetMouseButton(0))
        {
            Cursor.SetCursor(cursor[1], new Vector2(10,10), CursorMode.Auto);
            
        }
        else
        {
            Cursor.SetCursor(cursor[0], new Vector2(10, 10), CursorMode.Auto);
        }


        if (Input.GetMouseButtonDown(0))
        {
            soundChanel.clip = soundGrab;
            soundChanel.Play();
        }
       if(Input.GetMouseButtonUp(0))
        {
            soundChanel.clip = soundLeave;
            soundChanel.Play();
        }
    }
}
