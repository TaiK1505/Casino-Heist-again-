using System.Collections.Generic;
using UnityEngine;

namespace Tiles.Views
{
    public class DominoConstructionTest : MonoBehaviour
    {
        [SerializeField] private DominioViews viewTemplate;

        [SerializeField] private RectTransform contentContainer;
        
        public void InstantiateViews(List<DominoData> dominoData)
        {
            foreach (var dominoInfo in dominoData)
            {
                var clone = Instantiate(viewTemplate, contentContainer);
                clone.InitaliseDominoView(dominoInfo);
            }
            
        }
    }
}