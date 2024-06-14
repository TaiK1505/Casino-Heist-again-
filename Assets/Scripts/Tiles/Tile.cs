using System;
using Tiles;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class Tile : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool IsActive { get; set; } = true;

    [SerializeField] public SpriteRenderer Renderer;

    [SerializeField] private GameObject Highlight;
    internal Vector2Int GridPosition;

    public int X { get; private set; }
    public int Y { get; private set; }
    public int startingTileNumbers { get; internal set; }
    public int TileNumber { get; internal set; }

    [SerializeField]
    private TMP_Text text;

    protected GridManager gridManager;

    public virtual void Init(int x, int y, int tileNumber, GridManager gridManager)
    {
        X = x;
        Y = y;
        TileNumber = tileNumber;
        this.gridManager = gridManager;
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

    public void OnPointerEnter(PointerEventData eventData)
    {
        try
        {
            
            gridManager.AddSelfAsCurrentTile(this);
        }
        catch (Exception e)
        {
            Debug.LogError($"<color=red>{this}</color>");
            throw;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        try
        {
            
            gridManager.RemoveSelfAsCurrentTile(this);
        }
        catch (Exception e)
        {
            Debug.LogError($"<color=red>{this}</color>");
            throw;
        }
    }

    public void SetData(DominoData data)
    {
        text.text = data.PrimaryNumber.ToString();
        /*
         * Ask grid manager for neighbour cells
         * Select one, give it the secondary value
         */
    }
}
