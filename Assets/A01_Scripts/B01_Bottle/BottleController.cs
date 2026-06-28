using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace A01_Scripts.B01_Bottle
{
    public class BottleController : ImpMonoBehaviour
    {
        [SerializeField] List<int> _layer = new List<int>();
        [SerializeField] int _capacity = 4;

        public int GetTopColor() => _layer.Count > 0 ? _layer[_layer.Count - 1] : 0;

        public int GetTopColorCount()
        {
            if (_layer.Count == 0) return 0;
            int count = 0;
            int topColor = this.GetTopColor();
            for (int i = _layer.Count - 1; i >= 0; i--)
            {
                if (_layer[i] != topColor) break;
                count++;
            }
            return count;
        }

        public void RemoveTopColor() => _layer.RemoveAt(_layer.Count - 1);
        
        public void AddColor(int color) => _layer.Add(color);

        public bool IsFull() =>  _layer.Count >= _capacity;
        
        public bool IsEmpty() => _layer.Count == 0;
    }
}
