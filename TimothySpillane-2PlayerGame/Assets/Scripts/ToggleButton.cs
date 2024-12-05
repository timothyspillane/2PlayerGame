using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleButton : MonoBehaviour
{
    public GameObject[] toggleObjects;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Box"))
        {
            foreach( GameObject next in toggleObjects)
            {
                next.SetActive(!next.activeSelf);
            }
        }
    }
}
