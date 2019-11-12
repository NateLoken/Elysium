using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ares : BasePiece
{
    public Ares()
    {
        this.CurrentHealth = 300;
        this.MaxHealth = 300;
        this.Strength = 300;
        this.Movement = 4;
        this.Range = 1;
        this.Cost = 100;
    }
}
