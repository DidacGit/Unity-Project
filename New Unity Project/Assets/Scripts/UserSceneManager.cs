using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserSceneManager : MonoBehaviour
{

    public PlayerMovement player;
    public PlayerBox playerBox;
    public EnemyCreator enemyCreator;
    public PauseMenuScript menusManager;
    public bool started = false;
    public bool gameOver = false;

    private void Start()
    {
        
        Time.timeScale = 0f;
       
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !started)
        {
            started = true;
            Time.timeScale = 1f;
        }
        if(player.life <= 0)
        {
            player.life = 0;
            gameOver = true;
            menusManager.LoadDiedMenu();
        }
    }
}
