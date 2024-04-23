using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class GameManager : MonoBehaviour
{
    /*public static GameManager Instance;

    public GameState State;

    public static event Action<GameState> OnGameStateNameChange; 


    private void Awake()
    {
        Instance = this;
    }

     void Start()
    {
        UpadteGameState(GameState.SelectPlayer);
    }

    public void UpadteGameState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.SelectPlayer:
                HandleSelectPlayer();
                break;
            case GameState.SpawnGrid:
                GridManager.Instance.GenerateGrid();
                break;
            case GameState.PlayerOneTurn:
                break;
            case GameState.PlayerTwoTurn:
                break;
            case GameState.PlayerThreeTurn:
                break;
            case GameState.PlayerFourTurn:
                break;
            case GameState.Victory:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        OnGameStateNameChange ?.Invoke(newState);
    }

    private void HandleSelectPlayer()
    {
        
    }
    public enum GameState
    {
        SelectPlayer,
        SpawnGrid,
        PlayerOneTurn,
        PlayerTwoTurn,
        PlayerThreeTurn,
        PlayerFourTurn,
        Victory
    }*/
}
