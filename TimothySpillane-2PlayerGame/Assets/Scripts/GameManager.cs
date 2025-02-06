using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject WinPanel;
    [SerializeField] GameObject star1, star2, star3;
    [SerializeField] GameObject Player1, Player2;
    [SerializeField] private TMP_Text timeUI;
    [SerializeField] float timeGoal;
    [SerializeField] Sprite SunSprite, MoonSprite, AmericaSprite, VaticanSprite;


    private float startTime, elapsedTime;
    private string KeyName;

    // Update is called once per frame
    private void Awake()
    {
        Time.timeScale = 1f;
        if(!PlayerPrefs.HasKey("Points") || SceneManager.GetActiveScene().name == "Level1")
        {
            PlayerPrefs.SetInt("Points", 0);
        }
    }
    private void Start()
    {
        startTime = Time.time;
        Debug.Log(PlayerPrefs.GetInt("Points"));
        equipCosmetics();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)) // reload the scene when you press R
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if(null == GameObject.FindWithTag("Box"))// if there are no boxes, run Victory
        {
            Victory();
        }
        // update gameclock display
        int minutes;
        int seconds;
        int miliseconds;
        
        elapsedTime = Time.time - startTime; // timer code
        minutes = (int)elapsedTime / 60;
        seconds = (int)elapsedTime % 60;
        miliseconds = (int)(elapsedTime * 10) % 10;

        timeUI.text = $"{minutes}:{seconds}.{miliseconds}";
    }
    private void equipCosmetics()
    {
        if (PlayerPrefs.GetString("equippedCosmetic") == "10")
        {
            Player2.GetComponent<SpriteRenderer>().sprite = SunSprite;
            Player2.GetComponent<SpriteRenderer>().color = Color.white;
            Player1.GetComponent<SpriteRenderer>().sprite = MoonSprite;

        }else if (PlayerPrefs.GetString("equippedCosmetic") == "01")
        {
            Player2.GetComponent<SpriteRenderer>().sprite = AmericaSprite;
            Player1.GetComponent<SpriteRenderer>().sprite = VaticanSprite;

        }
    }
    private void Victory()
    {
        if (WinPanel.activeSelf) { return; }

        if(elapsedTime < timeGoal)// if you beat the game fast enough spawn all the stars
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") + 3);
        } else if(elapsedTime < timeGoal*2)
        {
            star1.SetActive(true);
            star3.SetActive(true);
            PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") + 2);
        }
        else
        {
            PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") + 1);
            star1.SetActive(false);
        }
        WinPanel.SetActive(true);// show win panel
        Time.timeScale = 0f;
    }
}
