using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void ClickOnStart()
    {
        //SceneManager.LoadScene("SampleScene");
    }

    public void ClickOnOptions()
    {
        //SceneManager.LoadScene("SampleScene");
    }

    public void ClickOnQuit()
    {
        Application.Quit();
        EditorApplication.isPlaying = false;
    }
}
