using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type {
    Head,
    RightArm,
    LeftArm,
    RightLeg,
    LeftLeg,
    Torso
}

public static class Global
{
    public static Outfit[] specialOutfits;
    public static Outfit[] allOutfits;
    public static BodyPart[] allBodyParts;
    public static Resources resources;
    public static SaveData saveData;
    public static bool isInitialized;

    public static void Initialize()
    {
        
    }

    public static void Save() {

    }

    public static void Load() {

    }

    public static void Reset() {

    }
}
