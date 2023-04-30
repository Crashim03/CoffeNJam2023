using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LoadResources : MonoBehaviour
{
    public Image[] heads = Resources.LoadAll<Image>("Heads");
    public Image[] rightArms = Resources.LoadAll<Image>("RightArms");
    public Image[] leftArms = Resources.LoadAll<Image>("LeftArms");
    public Image[] rightLegs = Resources.LoadAll<Image>("RightLegs");
    public Image[] leftLegs = Resources.LoadAll<Image>("LeftLegs");
    public Image[] torsos = Resources.LoadAll<Image>("Torsos");
    public OutfitData[] specialOutfits = Resources.LoadAll<OutfitData>("SpecialOutfits");
}
