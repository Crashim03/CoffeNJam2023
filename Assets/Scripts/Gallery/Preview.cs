using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Preview : MonoBehaviour
{
    [SerializeField] private TMP_Text tmp;
    public List<GameObject> menus = new List<GameObject>();

    public void changeName(string name)
    {
        tmp.text = name;
    }

    public void changeOutfit(List<BodyPart> bps)
    {
        for (int i = 0; i < menus.Count; i++)
        {
            menus[i].GetComponent<SpriteRenderer>().sprite = bps[i].sprite;
        }
    }
}
