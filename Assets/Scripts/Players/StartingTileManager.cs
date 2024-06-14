using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingTileManager : MonoBehaviour
{
    
    
    [SerializeField]
    private List<GameObject> startingTilePrefabs;
   
    [SerializeField] private GameObject startingTilePrefab1;
    [SerializeField] private GameObject startingTilePrefab2;
    [SerializeField] private GameObject startingTilePrefab3;
    [SerializeField] private GameObject startingTilePrefab4;  
   
    GridManager gridManager;
   

    public List<Tile> tileList = new List<Tile>();

    private void Start()
    {
        SetStartingPoints();
    }

    public void SetStartingPoints()
    {
        int[] startingTileNumbers = new int[]
        {
            4, 69, 60, 134,
        };

        var gridManager = SceneResources.Instance.GridManager;

        int index = 0;
        foreach (var tileNumber in startingTileNumbers)
        {
            Tile tile = GetTileByNumber(tileNumber);
            Debug.Log(tileNumber);
            Debug.Log($"Tile: {tile}");
            if (tile != null)
            {
                Debug.Log($"Tile: {tile}, {tile.X}, {tile.Y}");
                var spawnedTilePrefab = startingTilePrefabs[index];
                var spawnedTile = Instantiate(spawnedTilePrefab, gridManager.transform);
                spawnedTile.name = $"StartingTile{tileNumber}";
                spawnedTile.GetComponent<Tile>().Init(tile.X, tile.Y, tile.TileNumber, this.gridManager);
                spawnedTile.transform.localPosition = tile.transform.localPosition;
            }
            index++;
        }
    }

    private Tile GetTileByNumber(int tileNumber)
    {
        return SceneResources.Instance.GridManager.GetTileByNumber(tileNumber);
    }


}
