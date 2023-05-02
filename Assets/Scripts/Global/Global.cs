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
    public static List<Outfit> specialOutfits = new List<Outfit>();
    public static List<Outfit> allOutfits = new List<Outfit>();
    public static List<BodyPart> allBodyParts = new List<BodyPart>();
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
            allBodyParts.Add(new BodyPart(resources.heads[i], Type.Head, i));
        }

        for (int i = 0; i < resources.rightArms.Length; i++) {
            allBodyParts.Add(new BodyPart(resources.rightArms[i], Type.RightArm, i));
        }

        for (int i = 0; i < resources.leftArms.Length; i++) {
            allBodyParts.Add(new BodyPart(resources.leftArms[i], Type.LeftArm, i));
        }

        for (int i = 0; i < resources.rightLegs.Length; i++) {
            allBodyParts.Add(new BodyPart(resources.rightLegs[i], Type.RightLeg, i));
        }

        for (int i = 0; i < resources.leftLegs.Length; i++) {
            allBodyParts.Add(new BodyPart(resources.leftLegs[i], Type.LeftLeg, i));
        }

        for (int i = 0; i < resources.torsos.Length; i++) {
            allBodyParts.Add(new BodyPart(resources.torsos[i], Type.Torso, i));
        }
    }

    public static void Save() {

    }

    public static void Load() {

    }

    public static void Reset() {

    }
}
