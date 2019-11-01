using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zeus : BasePiece
{
    public Zeus()
    {
        this.CurrentHealth = 600;
        this.MaxHealth = 600;
        this.Strength = 300;
        this.Movement = 4;
        this.Range = 1;
        this.Cost = 200;
    }
}
