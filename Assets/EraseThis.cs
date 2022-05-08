using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraseThis : MonoBehaviour
{
    public Vector2 movements;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(movements*Time.deltaTime);
    }
}
