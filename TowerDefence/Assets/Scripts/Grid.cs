using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid 
{
    private int width;
    private int height;
    private float cellSize;
    private int[,] gridArray;
    public Grid(int width, int height, float cellSize)
    {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;

        gridArray = new int[width, height];

        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for(int y = 0; y < gridArray.GetLength(1); y++)
            {
                Debug.Log(x + " " + y);
                Debug.DrawLine(getWorldPosition(x, y), getWorldPosition(x, y + 1), Color.blue,100f);
                Debug.DrawLine(getWorldPosition(x, y), getWorldPosition(x+1, y), Color.blue, 100f);
            }
        }
        Debug.DrawLine(getWorldPosition(0, height), getWorldPosition(width, height), Color.blue, 100f);
        Debug.DrawLine(getWorldPosition(width, 0), getWorldPosition(width, height), Color.blue, 100f);
    }
    private Vector3 getWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * cellSize;
    }
    private void GetXY(Vector3 worldPosition, out int x, out int y)
    {
        x = Mathf.FloorToInt(worldPosition.x / cellSize);
        y = Mathf.FloorToInt(worldPosition.y / cellSize);
    }
    public void SetValue(int x, int y,int value)
    {
        if(x>=0 && y>=0 &&x<width && y < height)
        {
            gridArray[x, y] = value;
        }
    }

    public void SetValue(Vector3 worldPosition, int value)
    {
        int x, y;
        GetXY(worldPosition, out x, out y);
        SetValue(x, y, value);
    }
}
