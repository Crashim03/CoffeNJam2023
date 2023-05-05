using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Preview : MonoBehaviour
{
    [SerializeField] private TMP_Text tmp;
    public Outfit outfit;

    public void changeName(string name)
    {
        tmp.text = name;
    }

    public void SkeletonPreview() {
        Global.currentOutfit = outfit;
        Debug.Log("Button");
    }
}
