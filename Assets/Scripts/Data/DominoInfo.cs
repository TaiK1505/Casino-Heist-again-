using System;
using UnityEngine;

namespace Data
{
    [Serializable]
    public struct DominoInfo
    {
        [SerializeField] 
        private int primary;
        [SerializeField] 
        private int secondary;

        public int Primary => primary;
        public int Secondary => secondary;

        public DominoInfo(int primary, int secondary)
        {
            this.primary = primary;
            this.secondary = secondary;
        }
    }
    
    
}