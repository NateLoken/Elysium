using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hades : BasePiece
{ 
    public Hades()
    {
        this.CurrentHealth = 100;
        this.MaxHealth = 100;
        this.Strength = 200;
        this.Movement = 4;
        this.Range = 4;
        this.Cost = 100;
    }
}
