 using System;
 using System.Collections;
using System.Collections.Generic;
 using UnityEngine.UI;
using UnityEngine;
 using UnityEngine.EventSystems;

 public class BasePiece : EventTrigger
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
    public Color mColor = Color.clear;
    protected List<Cell> mHighlightedCells = new List<Cell>();
    protected Cell mTargetCell = null;
    protected Cell mCurrentCell = null;
    protected Cell mOriginalCell = null;
    protected RectTransform mRectTransform = null;
    protected PieceManager mPieceManager;
    protected Vector3Int mMovement = Vector3Int.one;

    public virtual void Setup(Color newTeamColor, Color32 newSpriteColor, PieceManager newPieceManager)
    {
        mPieceManager = newPieceManager;
        mColor = newTeamColor;
        GetComponent<Image>().color = newSpriteColor;
        mRectTransform = GetComponent<RectTransform>();
    }

    public void Place(Cell newCell)
    {
        mCurrentCell = newCell;
        mOriginalCell = newCell;
        mCurrentCell.currentPiece = this;
        transform.position = newCell.transform.position;
        gameObject.SetActive(true);
    }

    private void CreateCellPath(int xDir, int yDir, int mMove)
    {
        int currentX = mCurrentCell.mBoardPosition.x;
        int currentY = mCurrentCell.mBoardPosition.y;
        for (int i = 1; i <= movement; i++)
        {
            currentX += xDir;
            currentY += yDir;
            mHighlightedCells.Add(mCurrentCell.mBoard.mAllCells[currentX,currentY]);
        }
    }

    protected virtual void CheckPathing()
    {
        CreateCellPath(1,0,mMovement.x);
        CreateCellPath(-1,0,mMovement.x);
        
        CreateCellPath(0,1,mMovement.y);
        CreateCellPath(0,-1,mMovement.y);
        
        CreateCellPath(1,1,mMovement.z);
        CreateCellPath(-1,1,mMovement.z);
        
        CreateCellPath(-1,-1,mMovement.z);
        CreateCellPath(1,-1,mMovement.z);
    }

    protected void ShowCells()
    {
        foreach (var cell in mHighlightedCells)
        {
            cell.outlineImage.enabled = true;
        }
    }
    
    protected void ClearCells()
    {
        foreach (var cell in mHighlightedCells)
        {
            cell.outlineImage.enabled = false;
        }
        mHighlightedCells.Clear();
    }

    public override void OnBeginDrag(PointerEventData eventData)
    {
        base.OnBeginDrag(eventData);
        CheckPathing();
        ShowCells();
    }

    public override void OnDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);
        transform.position += (Vector3) eventData.delta;
        foreach (var cell in mHighlightedCells)
        {
            if (RectTransformUtility.RectangleContainsScreenPoint(cell.mRectTransform,Input.mousePosition))
            {
                mTargetCell = cell;
                break;
            }

            mTargetCell = null;
        }
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        base.OnEndDrag(eventData);
        ClearCells();
        if (!mTargetCell)
        {
            transform.position = mCurrentCell.gameObject.transform.position;
            return;
        }
        Move();
    }

    public void Reset()
    {
        Kill();
        Place(mOriginalCell);
    }

    public virtual void Kill()
    {
        mCurrentCell.currentPiece = null;
        gameObject.SetActive(false);
    }

    protected virtual void Move()
    {
        mTargetCell.RemovePiece();
        mCurrentCell.currentPiece = null;
        mCurrentCell = mTargetCell;
        mCurrentCell.currentPiece = this;
        transform.position = mCurrentCell.transform.position;
        mTargetCell = null;
    }

    public int Range { get => range; set => range = value; }
    public int Cost { get => cost; set => cost = value; }
    public int CurrentHealth { get => currentHealth; set => currentHealth = value; }
    public int MaxHealth { get => maxHealth; set => maxHealth = value; }
    public int Strength { get => strength; set => strength = value; }
    public int Movement { get => movement; set => movement = value; }
    public int PosX { get => posX; set => posX = value; }
    public int PosY { get => posY; set => posY = value; }
    
    
}
