using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class Manager : MonoBehaviour
{

    public List<GameObject> menus;
    public GameObject outfitName;

    private void Start() 
    {
        Global.Initialize();
        for (int i = 0; i < menus.Count; i++)
        {
            menus[i].GetComponent<OutfitChanger>().options = new List<BodyPart>();
        }
        for (int i = 0; i < Global.allBodyParts.Count; i++)
        {
            menus[(int)Global.allBodyParts[i].type].GetComponent<OutfitChanger>().options.Add(Global.allBodyParts[i]);
        }
        for (int i = 0; i < menus.Count; i++)
        {
            menus[i].GetComponent<OutfitChanger>().Initialize();
        }

        RandomButton();
    }

    public void SaveButton() {
        Global.Save();
    }

    public void LoadButton() {
        Global.Load();
    }

    public void CreateButon() {
        List<BodyPart> bps = new List<BodyPart>();
        for (int i = 0; i < menus.Count; i++)
        {
            bps.Add(menus[i].GetComponent<OutfitChanger>().currentPart);
        }
        int id = Global.CreateOutfit(bps, outfitName.GetComponent<TMP_InputField>().text);
        Global.Save();
        Global.LoadOutfit(id);
        SceneManager.LoadScene("Cinematic");
    }

    public void ResetButton() {
        Global.Reset();
    }

    public void RandomButton() {
        for (int i = 0; i < menus.Count; i++)
            menus[i].GetComponent<OutfitChanger>().Randomize();
    }

    public void ReturnButton() {
        SceneManager.LoadScene("MainMenu");
    }
}
