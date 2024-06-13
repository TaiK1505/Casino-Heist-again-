using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Players
{
    Player1,
    Player2,
    Player3,
    Player4
}

public class PlayerManager : MonoBehaviour
{
    // Tims code
    private static PlayerManager instance;
    public static PlayerManager Instance => instance;
    
    private MovementManager movementManager;
    private GridManager gridManager;
    
    public Text playerTurn;
    
    public bool isPlayer1;
    public bool isPlayer2;
    public bool isPlayer3;
    public bool isPlayer4;

    public GameObject player1Button;
    public GameObject player2Button;
    public GameObject player3Button;
    public GameObject player4Button;

    public Players currentPlayer;

    private void Start()
    {
        currentPlayer = Players.Player1;
        isPlayer1 = true;
        Debug.Log(currentPlayer);
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }

    public void ShowPlayer()
    {
        switch (currentPlayer)
        {
            case Players.Player1:
                isPlayer1 = true;
                isPlayer4 = false;
                break;
            case Players.Player2:
                isPlayer2 = true;
                isPlayer1 = false;
                break;
            case Players.Player3:
                isPlayer3 = true;
                isPlayer2 = false;
                break;
            case Players.Player4:
                isPlayer4 = true;
                isPlayer3 = false;
                break;
        }
            
    }

    public void Player1Button()
    {
        currentPlayer = Players.Player2;
        Debug.Log(currentPlayer);
        
        isPlayer2 = true;
        isPlayer1 = false;
        
        player1Button.SetActive(false);
        player2Button.SetActive(true);
        
        playerTurn.text = currentPlayer.ToString();
    }
    
    public void Player2Button()
    {
        currentPlayer = Players.Player3;
        Debug.Log(currentPlayer);
        
        isPlayer3 = true;
        isPlayer2 = false;
        
        player2Button.SetActive(false);
        player3Button.SetActive(true);
        
        playerTurn.text = currentPlayer.ToString();
    }
    
    public void Player3Button()
    {
        currentPlayer = Players.Player4;
        Debug.Log(currentPlayer);
        
        isPlayer4 = true;
        isPlayer3 = false;
        
        player3Button.SetActive(false);
        player4Button.SetActive(true);
        
        playerTurn.text = currentPlayer.ToString();
    }
    
    public void Player4Button()
    {
        currentPlayer = Players.Player1;
        Debug.Log(currentPlayer);
        
        isPlayer1 = true;
        isPlayer4 = false;
        
        player4Button.SetActive(false);
        player1Button.SetActive(true);
        playerTurn.text = currentPlayer.ToString();
    }

    void Player1()
    {
        if (isPlayer1 == true)
        {
            Debug.Log("Player Test" + currentPlayer);
        }
    }
    
    void Player2()
    {
        if (isPlayer2 == true)
        {
            Debug.Log("Player Test" + currentPlayer);
        }
    }
    
    void Player3()
    {
        if (isPlayer3 == true)
        {
            Debug.Log("Player Test" + currentPlayer);
        }
    }
    
    void Player4()
    {
        if (isPlayer4 == true)
        {
            Debug.Log("Player Test" + currentPlayer);
        }
    }
    


}
