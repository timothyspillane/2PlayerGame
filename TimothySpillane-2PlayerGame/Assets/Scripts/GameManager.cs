using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject WinPanel;
    [SerializeField] GameObject star1, star2, star3;
    [SerializeField] private TMP_Text timeUI;
    [SerializeField] float timeGoal;
    private float startTime, elapsedTime;

    // Update is called once per frame
    private void Awake()
    {
        Time.timeScale = 1f;
    }
    private void Start()
    {
        startTime = Time.time;
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
        // update gameclock display
        int minutes;
        int seconds;
        int miliseconds;
        
        elapsedTime = Time.time - startTime;
        minutes = (int)elapsedTime / 60;
        seconds = (int)elapsedTime % 60;
        miliseconds = (int)(elapsedTime * 10) % 10;

        timeUI.text = $"{minutes}:{seconds}.{miliseconds}";
    }
    private void Victory()
    {
        if(elapsedTime < timeGoal)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
        } else if(elapsedTime < timeGoal*2)
        {
            star1.SetActive(true);
            star3.SetActive(true);
        } else
        {
            star1.SetActive(false);
        }
        WinPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
