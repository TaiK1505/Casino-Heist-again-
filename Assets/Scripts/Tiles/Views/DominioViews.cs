using System;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

namespace Tiles.Views
{
    public class DominioViews : MonoBehaviour
    {
        private PlayerManager playerManager;
        
        [SerializeField] 
        private RectTransform dominoHalfTemplate;
        
        [SerializeField] 
        private RectTransform contentContainer;

        [SerializeField] private DominoTile template;

        private Vector3 offset;

        GridManager gridManager;
        
        private RectTransform firstHalf, secondHalf;

        public DominoData dominoData;

        private DominoTile clone;

        private void Start()
        {
            playerManager = PlayerManager.Instance;
        }

        private void Update()
        {
            offset = new Vector3(0.5f, 0, 0);
        }

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
            
            //First Turn
            
            Debug.Log($"Domino View "  +playerManager.currentPlayer);
            if (playerManager.currentPlayer == Players.Player1)
            {
                clone = Instantiate(template, gridManager.tilePos[4] + offset, quaternion.identity);
                clone.InitialiseDominoTile(dominoData);
                
            }

            if (playerManager.currentPlayer == Players.Player2)
            {
                clone = Instantiate(template, gridManager.tilePos[60] + offset, quaternion.identity);
                clone.InitialiseDominoTile(dominoData);
            }

            if (playerManager.currentPlayer == Players.Player3)
            {
                clone = Instantiate(template, gridManager.tilePos[69] + offset, quaternion.identity);
                clone.InitialiseDominoTile(dominoData);
            }

            if (playerManager.currentPlayer == Players.Player4)
            {
                clone = Instantiate(template, gridManager.tilePos[134] + offset, quaternion.identity);
                clone.InitialiseDominoTile(dominoData);
            }
            Debug.Log(dominoData);
            
        }

    }
}