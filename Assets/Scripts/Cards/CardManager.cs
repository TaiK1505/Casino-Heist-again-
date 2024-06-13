using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public Transform[] playerSlots;
    public bool[] emptyPlayerSlots;

    public void DealCard()
    {
        if (deck.Count >= 1)
        {
            Card randCard = deck[Random.Range(0, 4)];

            for (int i = 0; i < emptyPlayerSlots.Length; i++)
            {
                if (emptyPlayerSlots[i] == true)
                {
                    randCard.gameObject.SetActive(true);
                    randCard.transform.position = playerSlots[i].position;
                    emptyPlayerSlots[i] = false;
                    deck.Remove(randCard);
                    return;
                }
                
            }
        }
    }
}
