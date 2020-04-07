using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    // This variable is public so any other class can check if the game is paused or not
    public static bool GameIsPaused = false;
    // The canvas that makes the pause menu
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }
    // Hide the pause menu and resume the game
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    // Pause the game and show the pause menu
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadScores()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("ScoresMenu");
    }

    public void LoadSettings()
    {
        //SceneManager.LoadScene("ScoresMenu");
    }

    public void LoadLevelBase()
    {
        //SceneManager.LoadScene("LevelBase");
    }

    public void LoadMainMenu()
    {
        //SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
