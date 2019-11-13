using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
    private int turn;
    private int numPieces;

    public Player()
    {
        turn = 0;
        numPieces = 0;
    }

    public int Turn
    {
        get => turn;
        set => turn = value;
    }

    public int NumPieces
    {
        get => numPieces;
        set => numPieces = value;
    }
}
