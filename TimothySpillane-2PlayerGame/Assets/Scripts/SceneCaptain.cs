using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCaptain : MonoBehaviour
{
    public void LoadScenebyName(string sceneName) // load the scene that I put in the inspector
    {
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
