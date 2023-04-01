using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private float _sensitive = 10f;
    private float _zoomSpeed = 200f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal");
        float deltaZ = Input.GetAxis("Vertical");

        float mouseDeltaX = Input.GetAxis("Mouse X");

        float scrollWheel = Input.GetAxis("Mouse ScrollWheel");
        
        transform.Translate(deltaX, 0, deltaZ, Space.World);
        transform.Rotate(0, mouseDeltaX, 0, Space.World);
        
       
        transform.Translate(0, -scrollWheel * _zoomSpeed, 0, Space.World);
        Debug.LogFormat($"{transform.position.z}");

    }
}
