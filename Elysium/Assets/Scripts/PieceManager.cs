using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceManager: MonoBehaviour
{
    public static BasePiece targetUnit;
    public void rejuvination(Player player, BasePiece piece)
    {
        int endTurn = player.Turn + 5;
        if(player.Turn < endTurn)
        {
            if (piece.CurrentHealth != piece.MaxHealth)
                    piece.CurrentHealth += 20;
        }
    }

    public void revitalize(BasePiece piece)
    {
        piece.CurrentHealth = piece.MaxHealth;
    }

    public void petrify(Player player, BasePiece enemyPiece)
    {
        int intitialMovement = enemyPiece.Movement;
        int endTurn = player.Turn + 3;
        if (player.Turn < endTurn)
            enemyPiece.Movement = 0;
        else
            enemyPiece.Movement = intitialMovement;
    }

    public void worship(Player player, BasePiece piece)
    {
        int endTurn = player.Turn + 1;
        if(player.Turn < endTurn)
        {
            piece.CurrentHealth += 200;
            piece.Strength += 100;
        }
        else
        {
            piece.CurrentHealth -= 200;
            piece.Strength -= 100;
        }
    }

    public void exhaust(Player player, BasePiece enemyPiece)
    {
        //if increasing the turns movement and strength needs refactoring
        int endTurn = player.Turn + 1;
        if(player.Turn < endTurn)
        {
            enemyPiece.Strength -= 100;
            enemyPiece.Movement -= 2;
        }
        else
        {
            enemyPiece.Strength += 100;
        }
    }

    public static void MovePiece(BasePiece unit)
    {
        if(Input.GetMouseButtonDown(0))
        {
            unit.transform.position = Input.mousePosition;
        }
        
    }
}
