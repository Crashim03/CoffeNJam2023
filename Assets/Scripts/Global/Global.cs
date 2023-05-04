using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

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
    public static string path = Application.persistentDataPath + "/save.dat";
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
        GameObject gameObject = new GameObject("LoadResources");
        resources = gameObject.AddComponent<LoadResources>();
        saveData = new SaveData();
        int partCounter = 0;

        for (int i = 0; i < resources.heads.Length; i++) {
            allBodyParts.Add(new BodyPart(resources.heads[i], Type.Head, partCounter++));
        }

        for (int i = 0; i < resources.rightArms.Length; i++) {
            allBodyParts.Add(new BodyPart(resources.rightArms[i], Type.RightArm, partCounter++));
        }

        for (int i = 0; i < resources.leftArms.Length; i++) {
            allBodyParts.Add(new BodyPart(resources.leftArms[i], Type.LeftArm, partCounter++));
        }

        for (int i = 0; i < resources.rightLegs.Length; i++) {
            allBodyParts.Add(new BodyPart(resources.rightLegs[i], Type.RightLeg, partCounter++));
        }

        for (int i = 0; i < resources.leftLegs.Length; i++) {
            allBodyParts.Add(new BodyPart(resources.leftLegs[i], Type.LeftLeg, partCounter++));
        }

        for (int i = 0; i < resources.torsos.Length; i++) {
            allBodyParts.Add(new BodyPart(resources.torsos[i], Type.Torso, partCounter++));
        }

        createSpecialOutfits();
    }

    public static void createSpecialOutfits() {
        //TODO: Create special outfits
    }

    public static void Save() {
        saveData.outfits = new OutfitData[allOutfits.Count];

        for (int i = 0; i < allOutfits.Count; i++) {
           saveData.outfits[i] = new OutfitData(allOutfits[i]);
        }

        saveData.bodyParts = new BodyPartData[allBodyParts.Count];

        for (int i = 0; i < allBodyParts.Count; i++) {
            saveData.bodyParts[i] = new BodyPartData(allBodyParts[i]);
        }

        string jsonData = JsonUtility.ToJson(saveData);
        using (StreamWriter sw = File.CreateText(path)) {
            sw.WriteLine(jsonData);
        }
        Debug.Log(path);
    }   

    public static void Load() {
        if (!File.Exists(path)) {
            Debug.Log("Save file does not exist");
            return;
        }
        using (StreamReader sr = File.OpenText(path)) {
            string jsonData = sr.ReadLine();
            saveData = JsonUtility.FromJson<SaveData>(jsonData);
        }

        for (int i = 0; i < saveData.bodyParts.Length; i++) {

            allBodyParts[i].isUnlocked = saveData.bodyParts[i].isUnlocked;
            allBodyParts[i].id = saveData.bodyParts[i].id;
        }

        for (int i = 0; i < saveData.outfits.Length; i++) {
            Outfit outfit = ScriptableObject.CreateInstance<Outfit>();
            outfit.name = saveData.outfits[i].outfitName;
            outfit.date = saveData.outfits[i].date;
            outfit.id = saveData.outfits[i].id;
            for (int j = 0; j < saveData.outfits[i].bodyParts.Count; j++)
                outfit.bodyParts.Add(allBodyParts[saveData.outfits[i].bodyParts[j]]);

            allOutfits.Add(outfit);
        }
    }

    public static void Reset() {
        File.Delete(path);
        Initialize();
    }

    public static void CreateOutfit(List<BodyPart> bodyParts, string name)
    {
        Outfit outfit = ScriptableObject.CreateInstance<Outfit>();
        outfit.outfitName = name;
        outfit.date = System.DateTime.Now.ToString();
        outfit.id = allOutfits.Count;
        outfit.bodyParts.AddRange(bodyParts);
        allOutfits.Add(outfit);
    }
}
