using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseCanvas : MonoBehaviour
{
    public Canvas canvas;
    private void Start()
    {
        
    }

    public void Return()
    {
        canvas.enabled = false;
    }
}
