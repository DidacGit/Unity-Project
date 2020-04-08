using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void LoadScores()
    {
        SceneManager.LoadScene("ScoresMenu");
    }
    public void LoadSettings()
    {
        SceneManager.LoadScene("SettingsMenu");
    }
    public void LoadPlay()
    {
        SceneManager.LoadScene("LevelBase");
    }
    public void ExitGame()
    {
        Application.Quit();
    }

}
