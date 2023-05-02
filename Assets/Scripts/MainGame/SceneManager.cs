using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SceneManager : MonoBehaviour
{

    public List<GameObject> menus;


    private void Awake() 
    {
        Global.Initialize();
        for (int i = 0; i < Global.allBodyParts.Count; i++)
        {
            menus[(int)Global.allBodyParts[i].type].GetComponent<OutfitChanger>().options.Add(Global.allBodyParts[i]);
        }
        for (int i = 0; i < menus.Count; i++)
        {
            menus[i].SetActive(true);
        }
    }

}
