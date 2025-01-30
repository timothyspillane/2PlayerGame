using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    [SerializeField] TMP_Text PointText;
    [SerializeField] List<bool> cosmeticOwned;
    [SerializeField] int [] cosmeticCost;


    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") + 1000);
        Debug.Log(PlayerPrefs.GetInt("Points"));
        PointText.text = $"{PlayerPrefs.GetInt("Points")} Points";
        Load();
    }

    public void Button1()
    {
        if (cosmeticOwned.Count == 0)
        {
            return;
        }

        if (!cosmeticOwned[0] && PlayerPrefs.GetInt("Points") >= cosmeticCost[0])
        {
            PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") - 1);
            PointText.text = $"{PlayerPrefs.GetInt("Points")} Points";
            cosmeticOwned[0] = true ;
            Debug.Log("Item1Bought");
        }
    }
    public void Button2()
    {
        if (!cosmeticOwned[1] && PlayerPrefs.GetInt("Points") >= cosmeticCost[1])
        {
            PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") - 1);
            PointText.text = $"{PlayerPrefs.GetInt("Points")} Points";
            cosmeticOwned[1] = true;
            Debug.Log("Item2Bought");
        }
    }
    public void Save()
    {
        // save comsmetic owned array
        string cosmeticOwnedData = "";
        foreach (bool owned in cosmeticOwned)
        {
            if (owned)
            {
                cosmeticOwnedData += "1";
            }
            else
            {
                cosmeticOwnedData += "0";
            }
        }
        PlayerPrefs.SetString("ownedCosmetics", cosmeticOwnedData);
    }
    void Load()
    {
        cosmeticOwned = new List<bool>();
        foreach(char c in PlayerPrefs.GetString("ownedCosmetics"))
        {
            if (c == '1')
            {
                Debug.Log("Loading as TRUE");
                cosmeticOwned.Add(true);
            }
            if (c == '0')
            {
                Debug.Log("Loading as FALSE");
                cosmeticOwned.Add(false);
            }
        }
    }
}
