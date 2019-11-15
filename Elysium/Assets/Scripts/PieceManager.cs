using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceManager: MonoBehaviour
{
    public GameObject mPiecePrefab;

    private List<BasePiece> mWhitePieces = null;
    private List<BasePiece> mBlackPieces = null;

    private string[] mPieceOrder = new string[16]
    {
        "HA", "HE", "HA", "HE", "HA", "HE", "HA", "HE",
        "D", "ARE", "ART", "Z", "P", "ART", "ARE", "D"
    };

    private Dictionary<string, Type> mPieceLibrary = new Dictionary<string, Type>()
    {
        {"HE", typeof(Hermes)},
        {"HA", typeof(Hades)},
        {"D", typeof(Demeter)},
        {"ARE", typeof(Ares)},
        {"ART", typeof(Artemis)},
        {"Z", typeof(Zeus)},
        {"P", typeof(Poseidon)}
        
    };

    public void Setup(Board board)
    {
        mWhitePieces = CreatePieces(Color.white, new Color32(80, 124, 159, 255), board);
        mBlackPieces = CreatePieces(Color.black, new Color32(210, 95, 64, 255), board);
        PlacePieces(1, 0, mWhitePieces, board);
        PlacePieces(6, 7, mBlackPieces, board);

    }

    private List<BasePiece> CreatePieces(Color teamColor, Color32 spriteColor, Board board)
    {
        List<BasePiece> newPieces = new List<BasePiece>();

        for (int i = 0; i < mPieceOrder.Length; i++)
        {
            GameObject newPieceObject = Instantiate(mPiecePrefab, transform, true);
            newPieceObject.transform.localScale = new Vector3(0.15f,0.15f,1);
            newPieceObject.transform.localRotation = Quaternion.identity;
            
            string key = mPieceOrder[i];
            Type pieceType = mPieceLibrary[key];
            BasePiece newPiece = (BasePiece) newPieceObject.AddComponent(pieceType);
            newPieces.Add(newPiece);
            newPiece.Setup(teamColor,spriteColor,this);
            Canvas canvas = (Canvas)GameObject.FindObjectOfType(typeof(Canvas));
            GameObject canvasGameObject = canvas.gameObject;
            newPieceObject.transform.parent = canvasGameObject.transform;
        }

        return newPieces;
    }

    private void PlacePieces(int pawnRow, int royaltyRow, List<BasePiece> pieces, Board board)
    {
        for (int i = 0; i < 8; i++)
        {
            pieces[i].Place(board.mAllCells[i,pawnRow]);
            pieces[i+8].Place(board.mAllCells[i,royaltyRow]);
        }
    }
//    
//    public static BasePiece targetUnit;
//    public void rejuvination(Player player, BasePiece piece)
//    {
//        int endTurn = player.Turn + 5;
//        if(player.Turn < endTurn)
//        {
//            if (piece.CurrentHealth != piece.MaxHealth)
//                    piece.CurrentHealth += 20;
//        }
//    }
//
//    public void revitalize(BasePiece piece)
//    {
//        piece.CurrentHealth = piece.MaxHealth;
//    }
//
//    public void petrify(Player player, BasePiece enemyPiece)
//    {
//        int intitialMovement = enemyPiece.Movement;
//        int endTurn = player.Turn + 3;
//        if (player.Turn < endTurn)
//            enemyPiece.Movement = 0;
//        else
//            enemyPiece.Movement = intitialMovement;
//    }
//
//    public void worship(Player player, BasePiece piece)
//    {
//        int endTurn = player.Turn + 1;
//        if(player.Turn < endTurn)
//        {
//            piece.CurrentHealth += 200;
//            piece.Strength += 100;
//        }
//        else
//        {
//            piece.CurrentHealth -= 200;
//            piece.Strength -= 100;
//        }
//    }
//
//    public void exhaust(Player player, BasePiece enemyPiece)
//    {
//        //if increasing the turns movement and strength needs refactoring
//        int endTurn = player.Turn + 1;
//        if(player.Turn < endTurn)
//        {
//            enemyPiece.Strength -= 100;
//            enemyPiece.Movement -= 2;
//        }
//        else
//        {
//            enemyPiece.Strength += 100;
//        }
//    }
//
//  
//
////    public static void MovePiece(BasePiece unit)
////    {
////        if(Input.GetMouseButtonDown(0))
////        {
////            unit.transform.position = 
////        }
////        
////    }
}
