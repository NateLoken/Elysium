using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hermes : BasePiece
{
    public Hermes()
    {
        this.CurrentHealth = 100;
        this.MaxHealth = 100;
        this.Strength = 100;
        this.Movement = 6;
        this.Range = 1;
        this.Cost = 50;
    }
}
