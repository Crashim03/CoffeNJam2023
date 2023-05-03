using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BodyPartData
{
    public Type type;
    public bool isUnlocked;
    public int id;

    public BodyPartData(BodyPart bodyPart)
    {
        this.type = bodyPart.type;
        this.isUnlocked = bodyPart.isUnlocked;
        this.id = bodyPart.id;
    }
}
