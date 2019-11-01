using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTurn : MonoBehaviour
{
    public void EndPlayerTurn(float rotationAmount)
    {
        transform.Rotate(new Vector3(0, 0, 1), rotationAmount);
    }
}
