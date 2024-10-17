using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCaptain : MonoBehaviour
{
    public void LoadScenebyName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // When you get to the last level, a bug will occur
    }
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
