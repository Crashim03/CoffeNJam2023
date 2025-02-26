using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gallery : MonoBehaviour
{
    public void Reset() {
        Global.Reset();
        this.GetComponent<PopulateGrid>().Initialize();
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    public void Return() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    public void Coffee() {
        SceneManager.LoadScene("Cinematic");
    }
}
