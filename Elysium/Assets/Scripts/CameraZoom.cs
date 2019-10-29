using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float zoomSize = 10.0f;

    // Update is called once per frame
    void Update()
    {
        Camera gameCamera = GetComponent<Camera>();
        gameCamera.orthographicSize = zoomSize;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            zoomSize += 10;
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            zoomSize -= 10;
        }

//        if (Input.GetKey(KeyCode.A))
//        {
//            transform.Rotate();
//        }
            
    }
}
