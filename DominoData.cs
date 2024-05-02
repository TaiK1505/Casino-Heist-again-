using System;
using UnityEngine;

namespace Tiles
{
    [Serializable]
    public class DominoData
    {
        public int PrimaryNumber { get; private set; }
        public int SecondaryNumber { get; private set; }

        private bool isInitialised;

        public DominoData(int primary, int secondary)
        {
            PrimaryNumber = primary;
            SecondaryNumber = secondary;
            isInitialised = true;
        }
        
        public override string ToString()
        {
            return $"Primary Number: {PrimaryNumber}, Secondary Number: {SecondaryNumber}";
        }
    }
}