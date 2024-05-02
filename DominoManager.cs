using System.Collections.Generic;
using Data;
using Tiles;
using Tiles.Views;
using UnityEngine;

namespace Managers
{
    public class DominoManager : MonoBehaviour
    {
        [SerializeField] 
        private DominoCollectionData dominoCollection;

        [SerializeField]
        private List<DominoData> dominoData;

        [SerializeField] private DominoConstructionTest test;

        private void Start()
        {
            dominoData = dominoCollection.GetDominoData();
            test.InstantiateViews(dominoData);
        }

    }
}