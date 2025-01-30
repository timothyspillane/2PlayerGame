using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCaptain : MonoBehaviour
{
    private PointManager PointManager;
    private void Start()
    {
        PointManager = GetComponent<PointManager>();
    }
    public void LoadScenebyName(string sceneName) // load the scene that I put in the inspector
    {
        if (SceneManager.GetActiveScene().name == "Shop")
        {
            PointManager.Save();
            Debug.Log("SavingStore");
        }
        print("loading by name");
        SceneManager.LoadScene(sceneName);
    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // load the next level on the build
    }
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // reload the scene
    }
}
