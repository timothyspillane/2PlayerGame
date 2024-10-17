using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject WinPanel;
    // Update is called once per frame
    private void Awake()
    {
        Time.timeScale = 1f;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if(null == GameObject.FindWithTag("Box"))
        {
            Victory();
        }
    }
    private void Victory()
    {
        WinPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
