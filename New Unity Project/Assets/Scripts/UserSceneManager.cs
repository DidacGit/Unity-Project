using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UserSceneManager : MonoBehaviour
{

    public PlayerMovement player;
    public PlayerBox playerBox;
    public EnemyCreator enemyCreator;
    public PauseMenuScript menusManager;
    public Text textOnStart;
    public bool started = false;
    public bool gameOver = false;
    public float timeGame= 0f;
    public float finalTime = 90f;
    public Transform camera;
    public MeshCollider colliderPlayer;
    public GameObject wonMenu;

    private bool ending = false;
    private void Start()
    {
        
        Time.timeScale = 0f;
       
    }
    private void Update()
    {
        timeGame += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && !started || Input.GetKeyDown(KeyCode.Mouse0) && !started)
        {
            textOnStart.enabled = false;
            started = true;
            Time.timeScale = 1f;
        }
        if(player.life <= 0)
        {
            player.life = 0;
            gameOver = true;
            menusManager.LoadDiedMenu();
        }
        if ( timeGame >= finalTime)
        {
            FinalAnimation();
        }
        if (ending && timeGame >= 5f)
        {
            wonMenu.SetActive(true);
            Time.timeScale = 0f;
        }
            
    }

    private void FinalAnimation()
    {
        colliderPlayer.enabled = false;
        enemyCreator.transform.parent = null;
        camera.parent = null;
        timeGame = 0f;
        ending = true;

        Enemy[] enemys = FindObjectsOfType<Enemy>();

        foreach (Enemy e in enemys)
        {
            e.Explode();
        }
        
    }
}
