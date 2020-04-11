using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsMenuScript : MonoBehaviour
{
    public TextMeshProUGUI userName;
    public Slider slider;
    public Toggle toggle;
    
    private void Start()
    {
        
        userName.text = PlayerPrefsManager.getUserName();
        slider.value = PlayerPrefsManager.getVolume();

        if (PlayerPrefsManager.getMute() == 0) 
            toggle.isOn = false;
        else
            toggle.isOn = true;
    }

    public void ChangeVolume()
    {
        PlayerPrefsManager.setVolume(slider.value);
    }
    public void ChangeMute()
    {
        if(toggle.isOn)
            PlayerPrefsManager.setMute(1);
        else
            PlayerPrefsManager.setMute(0);
    }
    public void ChangeName()
    {
        
        if (userName.text.Equals("") || userName.text.Equals(" "))
        {
            userName.text = PlayerPrefsManager.getUserName();
        }
        else
        {
            PlayerPrefsManager.setUserName(userName.text);
        }
    }
    public void SceneBack()
    {
        // If we want it to be a real "back" button we have to change the SceneManager
        SceneManager.LoadScene("MainMenu");
    }
}
