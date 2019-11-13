 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePiece : MonoBehaviour
{
    private int currentHealth;
    private int maxHealth;
    private int strength;
    private int movement;
    private int range;
    private int cost;
    private int posX;
    private int posY;
    public Vector2 currentPos;

    public Vector2 targetPos;

    public int Range { get => range; set => range = value; }
    public int Cost { get => cost; set => cost = value; }
    public int CurrentHealth { get => currentHealth; set => currentHealth = value; }
    public int MaxHealth { get => maxHealth; set => maxHealth = value; }
    public int Strength { get => strength; set => strength = value; }
    public int Movement { get => movement; set => movement = value; }
    public int PosX { get => posX; set => posX = value; }
    public int PosY { get => posY; set => posY = value; }

    private void OnMouseDown()
    {
        Debug.Log("Piece clicked cum");
        PieceManager.MovePiece(this);
    }

}
