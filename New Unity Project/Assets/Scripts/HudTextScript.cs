using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudTextScript : MonoBehaviour
{
    public Transform playerPosition;
    public PlayerMovement myPlayerMovement;
    public Text hudText;

    // Update is called once per frame
    void Update()
    {
        string hud = "Position: " + playerPosition.position.z.ToString("0") + "\n" +
            "HP: " + myPlayerMovement.life + "\n" +
            "Ammo: " + myPlayerMovement.ammo;
        hudText.text = hud;
        //hudText.text = playerPosition.position.z.ToString("0");
    }
}
