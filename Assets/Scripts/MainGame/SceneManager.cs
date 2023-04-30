using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SceneManager : MonoBehaviour
{

    public List<GameObject> menus;


    private void Awake() 
    {
        for (int i = 0; i < Global.allBodyParts.Length; i++)
        {
            menus[(int)Global.allBodyParts[i].type].GetComponent<OutfitChanger>().options.Add(Global.allBodyParts[i]);
        }
    }

}
