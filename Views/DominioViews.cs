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

        private RectTransform firstHalf, secondHalf;

        private DominoData dominoData;

        public void InitaliseDominoView(DominoData data)
        {
            firstHalf = Instantiate(dominoHalfTemplate, contentContainer);
            secondHalf = Instantiate(dominoHalfTemplate, contentContainer);
            firstHalf.GetComponentInChildren<TMP_Text>().text = data.PrimaryNumber.ToString();
            secondHalf.GetComponentInChildren<TMP_Text>().text = data.SecondaryNumber.ToString();
            dominoData = data;
        }
    }
}