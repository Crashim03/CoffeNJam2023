using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyPart : ScriptableObject
{
    public Sprite sprite;
    public Type type;
    public bool isUnlocked;
    public int id;

    public BodyPart(Sprite sprite, Type type, int id)
    {
        this.sprite = sprite;
        this.type = type;
        this.id = id;
        this.isUnlocked = true;
    }
}
