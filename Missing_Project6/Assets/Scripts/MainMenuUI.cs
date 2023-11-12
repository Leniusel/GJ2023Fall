using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public GameObject settingsPanel; //allows new object to be referred to
    public void StartGame()
    {
        SceneManager.LoadScene(1); //open new scene
    }

    public void ExitGame()
    {
        Debug.Log("quitting"); //exit game but not really
        Application.Quit();
    }

    public void OpenSettings()
    {
        settingsPanel.SetActive(true); //activates the game object
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false); //close game object
    }
}
