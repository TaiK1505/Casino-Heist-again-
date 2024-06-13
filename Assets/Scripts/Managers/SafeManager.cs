using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeManager : MonoBehaviour
{
    private int safeCode;
    [SerializeField] private Text safeCodeText;
    
    private int keyCode1;
    private int keyCode2;

    void Start()
    {
        safeCode = Random.Range(0, 3);
        safeCodeText.text = safeCode.ToString();
    }
    
    void RollDice() // will be attached to button
    {
        keyCode1 = Random.Range(0, 3);
        keyCode2 = Random.Range(0, 3);
    }

     public void OpenSafe()
    {
        if (keyCode1 == safeCode)
        {
            //Loot safe
        }

        if (keyCode2 == safeCode)
        {
            //Loot safe
        }
    }

    void LootSafe()
    {
       
    }
}
