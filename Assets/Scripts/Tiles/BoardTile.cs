using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardTile : Tile
{
    [SerializeField] private Color orignalColor;
    [SerializeField] private Color offsetColor;

    public override void Init(int x, int y, int tileNumber, GridManager gridManager)
    {
        base.Init(x, y, tileNumber, gridManager);
        var isOffset = (x + y) % 2 == 1;
        Renderer.color = isOffset ? offsetColor : orignalColor;
    }
}
