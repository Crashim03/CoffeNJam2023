using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LoadResources : MonoBehaviour
{
    public Sprite[] heads;
    public Sprite[] rightArms;
    public Sprite[] leftArms;
    public Sprite[] rightLegs;
    public Sprite[] leftLegs;
    public Sprite[] torsos;
    public OutfitData[] specialOutfits;
    private void Awake()
    {
        heads = Resources.LoadAll<Sprite>("Heads");
        rightArms = Resources.LoadAll<Sprite>("RightArms");
        leftArms = Resources.LoadAll<Sprite>("LeftArms");
        rightLegs = Resources.LoadAll<Sprite>("RightLegs");
        leftLegs = Resources.LoadAll<Sprite>("LeftLegs");
        torsos = Resources.LoadAll<Sprite>("Torsos");
        specialOutfits = Resources.LoadAll<OutfitData>("SpecialOutfits");
    }
}
