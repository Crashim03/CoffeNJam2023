using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public List<GameObject> menus = new List<GameObject>();
    public TMP_Text outfitName;
    public TMP_Text date;

    private void Update() {
        if (Global.currentOutfit == null) return;
        if (outfitName != null) outfitName.text = Global.currentOutfit.outfitName;
        if (date != null) date.text = Global.currentOutfit.date;
        
        for (int i = 0; i < menus.Count; i++)
            menus[i].GetComponent<SpriteRenderer>().sprite = Global.currentOutfit.bodyParts[i].sprite;
    }
}
