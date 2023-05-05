using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<GameObject> menus = new List<GameObject>();
    
    private void Update() {
        if (Global.currentOutfit == null) return;
        for (int i = 0; i < menus.Count; i++)
            menus[i].GetComponent<SpriteRenderer>().sprite = Global.currentOutfit.bodyParts[i].sprite;
    }
}
