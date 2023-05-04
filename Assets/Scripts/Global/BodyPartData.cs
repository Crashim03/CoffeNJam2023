using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BodyPartData
{
    public bool isUnlocked;
    public int id;

    public BodyPartData(BodyPart bodyPart)
    {
        this.isUnlocked = bodyPart.isUnlocked;
        this.id = bodyPart.id;
    }
}
