using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class GameData
{
    // Name that the User has chosen in the settings. It will be saved with the score.
    [XmlAttribute("user_name")]
    public string userName;
    // Number from 1 to 4. Represents the levels that the user has unlocked.
    [XmlAttribute("levels")]
    public int levels;

    public GameData(string userName, int levels)
    {
        this.userName = userName;
        this.levels = levels;
    }
    public GameData() { }
}
