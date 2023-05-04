using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutfitChanger : MonoBehaviour
{
    [Header("Sprite Renderer")]
    public Image bodyPart;

    [Header("Sprite List")]
    public List<BodyPart> options;

    [Header("Body Part")]
    public BodyPart currentPart;
    public int currentOption = 0;

    public void Initialize()
    {
        Debug.Log(options[currentOption].sprite);
        currentPart = options[currentOption];
        bodyPart.sprite = currentPart.sprite;
    }

    public void NextOption()
    {
        currentOption++;  

        if (currentOption >= options.Count)
        {
            currentOption = 0;
        }

        while(!options[currentOption].isUnlocked)
        {
            currentOption++;
            if (currentOption >= options.Count)
            {
                currentOption = 0;
            }
        }


        currentPart = options[currentOption];
        bodyPart.sprite = currentPart.sprite;
    }

    public void PrevOption()
    {
        currentOption--;
                if (currentOption < 0)
        {
            currentOption = options.Count - 1;
        }
        
        while(!options[currentOption].isUnlocked)
        {
            currentOption--;
            if (currentOption < 0)
            {
                currentOption = options.Count - 1;
            }
        }


        currentPart = options[currentOption];
        bodyPart.sprite = currentPart.sprite;
    }

    public void Randomize() {
        currentOption = Random.Range(0, options.Count);
        while(!options[currentOption].isUnlocked)
        {
            currentOption = Random.Range(0, options.Count);
        }
        currentPart = options[currentOption];
        bodyPart.sprite = currentPart.sprite;
    }
}
