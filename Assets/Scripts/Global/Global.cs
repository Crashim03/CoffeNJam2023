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
    public static LoadResources resources;
    public static SaveData saveData;
    public static bool isInitialized = false;

    public static void Initialize()
    {
        if (isInitialized) return;
        isInitialized = true;
        resources = new LoadResources();
        saveData = new SaveData();

        for (int i = 0; i < resources.heads.Length; i++) {
            resources.heads[i].type = Type.Head;
        }
    }

    public static void Save() {

    }

    public static void Load() {

    }

    public static void Reset() {

    }
}
