using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LoadResources : MonoBehaviour
{
    public Sprite[] heads = Resources.LoadAll<Sprite>("Heads");
    public Sprite[] rightArms = Resources.LoadAll<Sprite>("RightArms");
    public Sprite[] leftArms = Resources.LoadAll<Sprite>("LeftArms");
    public Sprite[] rightLegs = Resources.LoadAll<Sprite>("RightLegs");
    public Sprite[] leftLegs = Resources.LoadAll<Sprite>("LeftLegs");
    public Sprite[] torsos = Resources.LoadAll<Sprite>("Torsos");
    public OutfitData[] specialOutfits = Resources.LoadAll<OutfitData>("SpecialOutfits");
}
