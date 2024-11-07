using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class GravityButton : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Box"))
        {
            FlipGravity();
        }
    }

    private void FlipGravity()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");
        foreach (GameObject items in players.Concat(boxes).ToArray())
        {
            items.GetComponent<Rigidbody2D>().gravityScale *= -1;
        }
    }


}
