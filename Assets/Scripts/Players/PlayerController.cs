using UnityEngine;

namespace Players
{
    public class PlayerController : MonoBehaviour
    {
        public enum PlayerTurn
        {
            player1,
            player2,
            player3,
            player4
        }

        public PlayerTurn currentPlayer = PlayerTurn.player1;

        public void SwitchTurns()
        {
            currentPlayer = (currentPlayer == PlayerTurn.player1) ? PlayerTurn.player2 : PlayerTurn.player1;
            Debug.Log($"Current Player is {currentPlayer}");
        }
    }
}