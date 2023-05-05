using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject button;
    public void Awake() {
        Global.Initialize();
    }
    public void Start() {
        if (Global.currentOutfit == null) {
            button.GetComponent<UnityEngine.UI.Button>().interactable = false;
        }
    }

    public void PlayButton() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainGame");
    }

    public void GalleryButton() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Gallery");
    }

    public void Quit() {
        Application.Quit();
    }
}
