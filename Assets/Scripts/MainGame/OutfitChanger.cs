using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutfitChanger : MonoBehaviour
{
    [Header("Sprite Renderer")]
    [SerializeField] private Image bodyPart;

    [Header("Sprite List")]
    public List<BodyPart> options = new List<BodyPart>();

    private int currentOption = 0;

    private void Awake() {
        bodyPart.sprite = options[currentOption].sprite;
    }

    public void NextOption()
    {
        currentOption++;
        if (currentOption >= options.Count)
        {
            currentOption = 0;
        }

        bodyPart.sprite = options[currentOption].sprite;
    }

    public void PrevOption()
    {
        currentOption--;
        if (currentOption < 0)
        {
            currentOption = options.Count - 1;
        }

        bodyPart.sprite = options[currentOption].sprite;
    }
}
