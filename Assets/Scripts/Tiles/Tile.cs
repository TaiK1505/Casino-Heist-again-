using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tile : MonoBehaviour
{
    public bool IsActive { get; set; } = true;
    
    [SerializeField] public SpriteRenderer Renderer;

    [SerializeField] private GameObject Highlight;

    public int X { get; private set; }
    public int Y { get; private set; }
    
    public virtual void Init(int x, int y)
    {
        X = x;
        Y = y;
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
