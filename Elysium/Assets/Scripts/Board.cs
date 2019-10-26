using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
    public GameObject mCellPrefab;
    [HideInInspector] public Cell[,] mAllCells = new Cell[21,21];

    public void Create()    
    {
        for (var y = 0; y < 20; y++)
        {
            for (var x = 0; x < 20; x++)
            {
                var newCell = Instantiate(mCellPrefab, transform);
                var rectTransform = newCell.GetComponent<RectTransform>();
                rectTransform.anchoredPosition = new Vector2((x * 100) + 50, (y * 100) + 50);
                
                mAllCells[x,y] = newCell.GetComponent<Cell>();
                mAllCells[x,y].Setup(new Vector2Int(x, y), this);
            }
        }

        for (var x = 0; x < 20; x += 2)
        {
            for (var y = 0; y < 20; y++)
            {
                var offset = (y % 2 != 0) ? 0 : 1;
                var finalX = x + offset;
                
                mAllCells[finalX, y].GetComponent<Image>().color = new Color32(230, 220, 187, 255);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
