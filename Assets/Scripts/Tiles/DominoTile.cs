using System.Collections;
using System.Collections.Generic;
using Tiles;
using TMPro;
using UnityEngine;

public class DominoTile : MonoBehaviour
{
    private DominoData dominoData;

    [SerializeField]
    private TMP_Text primaryTextDisplay, secondaryTextDisplay;
    
    
    public void InitialiseDominoTile(DominoData data)
    {
        dominoData = data;
        primaryTextDisplay.text = dominoData.PrimaryNumber.ToString();
        secondaryTextDisplay.text = dominoData.SecondaryNumber.ToString();
    }
}
