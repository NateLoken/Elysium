using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artemis : BasePiece
{
    public Artemis()
    {
        this.CurrentHealth = 100;
        this.MaxHealth = 100;
        this.Strength = 100;
        this.Movement = 3;
        this.Range = 6;
        this.Cost = 100;
    }
}
