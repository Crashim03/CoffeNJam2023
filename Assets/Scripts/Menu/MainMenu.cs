using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void Awake() {
        Global.Initialize();
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
