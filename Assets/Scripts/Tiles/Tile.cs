using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tile : MonoBehaviour
{
    [SerializeField] protected SpriteRenderer Renderer;

    [SerializeField] private GameObject Highlight;

    public virtual void Init(int x, int y)
    {
        
    }
    void OnMouseEnter()
    {
        Highlight.SetActive(true);
    }
    void OnMouseExit()
    {
        Highlight.SetActive(false);
    }

}
