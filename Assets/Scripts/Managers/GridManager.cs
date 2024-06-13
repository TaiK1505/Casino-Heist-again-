using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class GridManager : MonoBehaviour
{
    public static GridManager Instance;
    
    public int Width;
    public int Height;

    [SerializeField] private Tile boardTile;
    [SerializeField] private Tile obstacleTile;
    [SerializeField] private Tile startingTile;
    [SerializeField] private Tile Safe;

    [SerializeField] private Transform Camera;

    [SerializeField] private StartingTileManager startingTileManager;
    
    public List<Tile> tileList = new List<Tile>();
    public List<Vector3> tilePos = new List<Vector3>();

    
    void Awake()
    {
        Instance = this;
    }
    

    private void Start()
    {
        GenerateGrid();
        SpawnSafes();
        SpawnObstacles();
        
        //Debug.Log(tilePos[6]);
    }

    public void GenerateGrid()
    {
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                var randomTile = Random.Range(0, 100) == 5 ? obstacleTile : boardTile;
                var spawnedTile = Instantiate(randomTile, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"{x}{y}";
                var tileIndex = x * Height + y;
                spawnedTile.Init(x, y, tileIndex);
                tileList.Add(spawnedTile);
            }
        }   
            Camera.transform.position = new Vector3((float)Width / 2 - 0.5f, (float)Height / 2 - 0.5f, -10);
        
        
    }
    
    public void SpawnSafes()
    {
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                Vector3 position = new Vector3(x , y , 0f);
                tilePos.Add(position);
            }
        }
        //Safe 1
        Instantiate(Safe, tilePos[54], Quaternion.identity); 
        Instantiate(Safe, tilePos[55], Quaternion.identity);
        
        //Safe 2
        Instantiate(Safe, tilePos[84], Quaternion.identity); 
        Instantiate(Safe, tilePos[85], Quaternion.identity);
        
        //Safe3
        Instantiate(Safe, tilePos[27], Quaternion.identity); 
        Instantiate(Safe, tilePos[28], Quaternion.identity);
        Instantiate(Safe, tilePos[38], Quaternion.identity);
        
        //Safe4
        Instantiate(Safe, tilePos[111], Quaternion.identity); 
        Instantiate(Safe, tilePos[112], Quaternion.identity);
        
    }

    public void SpawnObstacles()
    {
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                Vector3 position = new Vector3(x , y , 0f);
                tilePos.Add(position);
            }
        }

        Instantiate(obstacleTile, tilePos[21], Quaternion.identity);
        Instantiate(obstacleTile, tilePos[31], Quaternion.identity);
        Instantiate(obstacleTile, tilePos[36], Quaternion.identity);
        Instantiate(obstacleTile, tilePos[37], Quaternion.identity);
        Instantiate(obstacleTile, tilePos[64], Quaternion.identity);
        Instantiate(obstacleTile, tilePos[75], Quaternion.identity);
        Instantiate(obstacleTile, tilePos[103], Quaternion.identity);
        Instantiate(obstacleTile, tilePos[108], Quaternion.identity);
        Instantiate(obstacleTile, tilePos[117], Quaternion.identity);
        Instantiate(obstacleTile, tilePos[127], Quaternion.identity);
    }

    public Tile GetTileByNumber(int tileNumber)
    {
        foreach (var startingTile in tileList)
        {
            Debug.Log($"{startingTile.TileNumber} == {tileNumber}");
            if (startingTile.TileNumber == tileNumber)
            {
                return startingTile;
            }
        }
        return null;
    }
    
    private void SetStartingPoints()
    {
        int[] startingTileNumbers = new int[]
        {
            4, 69, 60, 134, 
        };

        foreach (var tileNumber in startingTileNumbers)
        {
            var tile = GetTileByNumber(tileNumber);
            if (tile != null)
            {
           
                var spawnedTile = Instantiate(startingTile, tile.transform.position, Quaternion.identity);
                spawnedTile.name = $"StartingTile{tileNumber}";
                spawnedTile.Init(tile.X, tile.Y, tile.TileNumber);
            
            }
        }
    }

}
