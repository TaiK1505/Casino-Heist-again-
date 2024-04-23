using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GridManager : MonoBehaviour
{
    public static GridManager Instance;
    
    [SerializeField] private int Width;
    [SerializeField] private int Height;

    [SerializeField] private Tile boardTile;
    [SerializeField] private Tile obstacleTile;

    [SerializeField] private Transform Camera;
    
    private Dictionary<Vector2, Tile> Tiles;

    void Awake()
    {
        Instance = this;
    }
    

    private void Start()
    {
        GenerateGrid();
    }

    public void GenerateGrid()
    {
        Tiles = new Dictionary<Vector2, Tile>();
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                var randomTile = Random.Range(0, 20) == 5 ? obstacleTile : boardTile;
                var spawnedTile = Instantiate(randomTile,new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"Tile{x}{y}";

                
                spawnedTile.Init(x, y);

                Tiles[new Vector2(x, y)] = spawnedTile;
            }
        }

        Camera.transform.position = new Vector3((float)Width / 2 - 0.5f, (float)Height / 2 - 0.5f, -10);
        
        //GameManager.Instance.UpadteGameState(GameManager.GameState.SpawnGrid);
    }

    public Tile GetTileAtPosition(Vector2 pos)
    {
        if (Tiles.TryGetValue(pos, out var tile))
        {
            return tile;
        }

        return null;
    }

}
