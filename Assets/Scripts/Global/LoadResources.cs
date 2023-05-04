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
    private void Awake()
    {
        heads = Resources.LoadAll<Sprite>("Heads");
        rightArms = Resources.LoadAll<Sprite>("Right Arms");
        leftArms = Resources.LoadAll<Sprite>("Left Arms");
        rightLegs = Resources.LoadAll<Sprite>("Right Legs");
        leftLegs = Resources.LoadAll<Sprite>("Left Legs");
        torsos = Resources.LoadAll<Sprite>("Torsos");
    }
}
