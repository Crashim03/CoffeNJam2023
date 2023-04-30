using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "OutfitData", menuName = "CoffeNJam2023/OutfitData", order = 0)]
public class OutfitData : ScriptableObject
{
    public BodyPartData head;
    public BodyPartData rightArm;
    public BodyPartData leftArm;
    public BodyPartData rightLeg;
    public BodyPartData leftLeg;
    public BodyPartData torso;
    public string outfitName;
    public string date;
    public int id;
}
