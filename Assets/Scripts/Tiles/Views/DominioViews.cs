using System;
using TMPro;
using UnityEngine;

namespace Tiles.Views
{
    public class DominioViews : MonoBehaviour
    {
        [SerializeField] 
        private RectTransform dominoHalfTemplate;
        
        [SerializeField] 
        private RectTransform contentContainer;

        [SerializeField] private DominoTile template;

        GameManager gameManager;
        
        private RectTransform firstHalf, secondHalf;

        private DominoData dominoData;

        private DominoTile clone;

        public void InitaliseDominoView(DominoData data)
        {
            firstHalf = Instantiate(dominoHalfTemplate, contentContainer);
            secondHalf = Instantiate(dominoHalfTemplate, contentContainer);
            firstHalf.GetComponentInChildren<TMP_Text>().text = data.PrimaryNumber.ToString();
            secondHalf.GetComponentInChildren<TMP_Text>().text = data.SecondaryNumber.ToString();
            dominoData = data;
        }

        public void OnClickCreateDominoTile()
        {
            Debug.Log("OnClickCreateDominoTile");
            
            var gridManager = SceneResources.Instance.GridManager;

            clone = Instantiate(template, gridManager.transform);
            clone.InitialiseDominoTile(dominoData);
        }

    }
}