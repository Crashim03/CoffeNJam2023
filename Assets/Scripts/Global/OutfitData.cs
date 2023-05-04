using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class OutfitData
{
    public List<int> bodyParts = new List<int>();
    public string outfitName;
    public string date;
    public int id;

    public OutfitData(Outfit outfit)
    {
        for (int i = 0; i < outfit.bodyParts.Count; i++)
        {
            this.bodyParts.Add(outfit.bodyParts[i].id);
        }
        this.outfitName = outfit.outfitName;
        this.date = outfit.date;
        this.id = outfit.id;
    }
}
