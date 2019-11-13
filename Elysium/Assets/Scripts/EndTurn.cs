using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTurn : MonoBehaviour
{
    public void EndPlayerTurn(float rotationAmount, Player player)
    {
        transform.Rotate(new Vector3(0, 0, 1), rotationAmount);
        player.Turn += 1;
    }
}
