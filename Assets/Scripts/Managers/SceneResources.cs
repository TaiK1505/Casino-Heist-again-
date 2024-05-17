using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneResources : MonoBehaviour
{
    private static SceneResources instance;

    public static SceneResources Instance => instance;

    [SerializeField] private GridManager gridManager;
    public GridManager GridManager => gridManager;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
}
