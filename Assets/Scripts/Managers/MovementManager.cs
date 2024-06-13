using System;
using System.Collections;
using System.Collections.Generic;
using Tiles;
using Tiles.Views;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    public static MovementManager Instance;

    private GridManager gridManager;
    private DominioViews dominoViews;

    private void Awake()
    {
        Instance = this;
    }


    /*void PlayableTiles()
    {
        for (int x = 0; x < gridManager.Width; x++)
        {
            for (int y = 0; y < gridManager.Height; y++)
            {
                if ()
            }

        }

    }*/

    void PlayableDominoes()
    {
        {
            
        }
    }
}