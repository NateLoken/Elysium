using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10.0f;
    private void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(-speed * Time.deltaTime,0));
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(speed * Time.deltaTime,0));
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector2(0,speed * Time.deltaTime));
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector2(0,-speed * Time.deltaTime));
        }
    }
}
