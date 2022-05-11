using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse1 : MonoBehaviour
{
    public Texture2D[] cursor;

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
    }
}
