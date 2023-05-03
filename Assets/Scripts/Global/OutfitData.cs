using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class OutfitData
{
    public int head;
    public int rightArm;
    public int leftArm;
    public int rightLeg;
    public int leftLeg;
    public int torso;
    public string outfitName;
    public string date;
    public int id;

    public OutfitData(Outfit outfit)
    {
        this.head = outfit.head.id;
        this.rightArm = outfit.rightArm.id;
        this.leftArm = outfit.leftArm.id;
        this.rightLeg = outfit.rightLeg.id;
        this.leftLeg = outfit.leftLeg.id;
        this.torso = outfit.torso.id;
        this.outfitName = outfit.outfitName;
        this.date = outfit.date;
        this.id = outfit.id;
    }
}
