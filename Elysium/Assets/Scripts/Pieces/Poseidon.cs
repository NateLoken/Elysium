using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poseidon : BasePiece
{
    public Poseidon()
    {
        this.CurrentHealth = 200;
        this.MaxHealth = 200;
        this.Strength = 200;
        this.Movement = 4;
        this.Range = 2;
        this.Cost = 100;
    }
}
