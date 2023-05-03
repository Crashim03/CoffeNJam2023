using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Outfit", menuName = "Outfit")]
public class Outfit : ScriptableObject
{
    public List<BodyPart> bodyParts = new List<BodyPart>();
    public string outfitName;
    public string date;
    public int id;
}
