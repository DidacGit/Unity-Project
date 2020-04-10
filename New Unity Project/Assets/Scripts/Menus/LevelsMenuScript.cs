using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelsMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Change the title colors here, when the completed levels' data is implemented
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("LevelBase");
    }
    public void LoadLevel2()
    {
        //SceneManager.LoadScene("Level2");
    }
    public void LoadLevel3()
    {
        //SceneManager.LoadScene("Level3");
    }
    public void LoadLevel4()
    {
        //SceneManager.LoadScene("Level4");
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
