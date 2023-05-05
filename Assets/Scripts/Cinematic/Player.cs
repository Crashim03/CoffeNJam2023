using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<GameObject> menus= new List<GameObject>();
    
    private void Awake() {
        for (int i = 0; i < menus.Count; i++)
            menus[i].GetComponent<SpriteRenderer>().sprite = Global.currentOutfit.bodyParts[i].sprite;
    }
}
