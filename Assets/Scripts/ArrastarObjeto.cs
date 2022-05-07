using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrastarObjeto : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(pos.x, pos.y, 0);
    }
}
