using System;
using A01_Scripts.B01_Bottle;
using UnityEngine;

public class GameManager : ImpSingleton<GameManager>
{
    public bool Pour(BottleController sourceBottle, BottleController targetBottle)
    {
        if (sourceBottle.IsEmpty() || targetBottle.IsFull() || sourceBottle == targetBottle) return false;
        
        int sourceColor = sourceBottle.GetTopColor();
        int targetColor = targetBottle.GetTopColor();

        if (targetBottle.IsEmpty() || sourceColor == targetColor)
        {
            for (int i = 0; i < sourceBottle.GetTopColorCount(); i++)
            {
                if (targetBottle.IsFull()) break;
                sourceBottle.RemoveTopColor();
                targetBottle.AddColor(sourceColor);
            }
        }
        
        return true;
    }
}
