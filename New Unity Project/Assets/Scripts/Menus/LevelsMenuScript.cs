using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelsMenuScript : MonoBehaviour
{
    public int level = 0;
    private bool unlockLevel2 = false;
    private bool unlockLevel3 = false;
    private bool unlockLevel4 = false;

    // Start is called before the first frame update
    void Start()
    {
        level = PlayerPrefsManager.getLevel();
        if (level > 1)
        {
            unlockLevel2 = true;
            // Put the other color to the text
            if (level > 2)
            {
                unlockLevel3 = true;
                // Put the other color to the text
                if (level > 3)
                {
                    unlockLevel4 = true;
                    // Put the other color to the text
                }
            }
        }
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("LevelBase");
    }
    public void LoadLevel2()
    {
        if (unlockLevel2)
        {
            SceneManager.LoadScene("Level2");
        }
    }
    public void LoadLevel3()
    {
        if (unlockLevel3)
        {
            SceneManager.LoadScene("Level3");
        }
    }
    public void LoadLevel4()
    {
        if (unlockLevel4)
        {
            SceneManager.LoadScene("Level4");
        }
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
