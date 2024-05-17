using System;
using System.Collections;
using System.Collections.Generic;
using Players;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    public static MovementManager Instance;
    
    private SpriteRenderer Renderer;
    public Color newColor;

    PlayerController playerController;

    public void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Renderer = GetComponent<SpriteRenderer>();
    }

    public void Update()
    {
        // Convert mouse position to world point
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Check if mouse position overlaps with the tile collider
        if (GetComponent<Collider2D>().OverlapPoint(mousePosition))
        { 
            // Change the color of the tile when clicked
            if (Input.GetMouseButtonDown(0))
            {
                Renderer.color = newColor;
            }
        }
    }
        
    
    
    
}
