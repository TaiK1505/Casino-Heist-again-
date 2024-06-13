using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField] private GameObject dominoPanel;
    [SerializeField] private GameObject openButton;
    [SerializeField] private GameObject closeButton;
    
    public void HideDominos()
    {
        dominoPanel.SetActive(false);
        openButton.SetActive(true);
        closeButton.SetActive(false);
    }

    public void ShowDominos()
    {
        dominoPanel.SetActive(true);
        openButton.SetActive(false);
        closeButton.SetActive(true);
    }
}
