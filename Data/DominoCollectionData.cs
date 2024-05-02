using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Tiles;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "DominoCollection.asset", menuName = "Casino Heist/Domino Collectio", order = 0)]
    public class DominoCollectionData : ScriptableObject
    {
        private const string DOMINIO_DATA_PATH = "Assets/Data/Domino - Sheet1.csv";

        [SerializeField]
        private List<DominoInfo> dominoStorage;

        public List<DominoData> GetDominoData()
        {
            var list = new List<DominoData>();
            foreach (var domino in dominoStorage)
            {
                var newDomino = new DominoData(domino.Primary, domino.Secondary);
                list.Add(newDomino);
            }
            return list;
        }
    }
}