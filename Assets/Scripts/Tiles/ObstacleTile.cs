using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTile : Tile
{
    public override void Init(int x, int y, int tileNumber, GridManager gridManager)
    {
        base.Init(x, y, tileNumber, gridManager);
    }

    public void SetGridManger(GridManager gridManager)
    {
        this.gridManager = gridManager;
    }
}
