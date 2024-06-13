using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class Tile : MonoBehaviour
{
    public bool IsActive { get; set; } = true;

    [SerializeField] public SpriteRenderer Renderer;

    [SerializeField] private GameObject Highlight;
    internal Vector2Int GridPosition;

    public int X { get; private set; }
    public int Y { get; private set; }
    public int startingTileNumbers { get; internal set; }
    public int TileNumber { get; internal set; }

    public virtual void Init(int x, int y, int tileNumber)
    {
        X = x;
        Y = y;
        TileNumber = tileNumber;
    }

    

    private void OnMouseEnter()
    {
        if (IsActive)
        {
            Highlight.SetActive(true);
        }
    
    }
    private void OnMouseExit()
    {
        if (IsActive)
        {
            Highlight.SetActive(false);    
        } 
    }
}
