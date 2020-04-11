using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoresMenuScript : MonoBehaviour
{
    private string rootFolder;
    ScoresCollection scoresCollection;
    private void Start()
    {
#if UNITY_EDITOR
        rootFolder = Application.dataPath;
        //Si estamos en Android o iOS cogerá el path de persistentDataPath, que es una carpeta que crea unity en estos dispositivos con
        //los archivos que necesitará mas tarde como es el caso
#elif UNITY_ANDROID || UNITY_IOS
        rootFolder = Application.persistentDataPath;
#endif
        scoresCollection = ScoresCollection.Load(Path.Combine(rootFolder, "scores.xml"));
        //scoresCollection.scores.Sort(,,,);
    }
    public void LoadShowAll()
    {
        //SceneManager.LoadScene("TODO");
    }
    public void SceneBack()
    {
        // If we want it to be a real "back" button we have to change the SceneManager
        SceneManager.LoadScene("MainMenu");
    }
}
