using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Outfit", menuName = "Outfit")]
public class Outfit : ScriptableObject
{
    public BodyPart head;
    public BodyPart rightArm;
    public BodyPart leftArm;
    public BodyPart rightLeg;
    public BodyPart leftLeg;
    public BodyPart torso;
    public string outfitName;
    public string date;
    public int id;
}
