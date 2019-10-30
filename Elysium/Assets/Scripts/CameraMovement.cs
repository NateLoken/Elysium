using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed = 100.0f;
    private float _time;
    private float currY;
    public Camera interpolateCam;
    private bool zoomIn = false, zoomOut = false, zoomedIn = false;

    void Update()
    {

        if (Input.GetButtonDown("Zoom In"))
        {
            if(!zoomedIn)
                zoomIn = true;
            zoomedIn = true;
        }
        if (Input.GetButtonDown("Zoom Out"))
        {
            if (zoomedIn)
                zoomOut = true;
            zoomedIn = false;
        }

        if (zoomIn)
        {
            _time += Time.deltaTime / 1.0f;
            interpolateCam.orthographicSize = Mathf.SmoothStep(210, 105, _time);
            if (_time > 1.0f)
            {
                _time = 0;
                zoomIn = false;
            }
        }

        if (zoomOut)
        {
            _time += Time.deltaTime / 1.0f;
            interpolateCam.orthographicSize = Mathf.SmoothStep(105, 210, _time);
            interpolateCam.transform.position = new Vector3(0, Mathf.SmoothStep(currY, 0, _time), -30);
            if (_time > 1.0f)
            {
                _time = 0;
                zoomOut = false;
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (interpolateCam.transform.position.y > -100 && zoomedIn)
            {
                transform.Translate(new Vector2(0, -speed * Time.deltaTime));
                currY = interpolateCam.transform.position.y;
            }
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (interpolateCam.transform.position.y < 100 && zoomedIn)
            {
                transform.Translate(new Vector2(0, speed * Time.deltaTime));
                currY = interpolateCam.transform.position.y;
            }
        }
    }
}
