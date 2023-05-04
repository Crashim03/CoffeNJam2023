using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Preview : MonoBehaviour
{
    [SerializeField] private TMP_Text tmp;

    public void changeName(string name)
    {
        tmp.text = name;
    }
}
