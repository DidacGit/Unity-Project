using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public PlayerMovement player;
    public PlayerBox playerBox;
    public EnemyCreator enemyCreator;
    public bool started = false;
    public bool gameOver = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !started)
        {
            started = true;
        }
        if(player.life <= 0)
        {
            gameOver = true;
        }
    }
}
