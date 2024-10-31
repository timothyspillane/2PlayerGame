using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Box Destroyer"))// if the box is colliding with a box destroyer, destroy the box
         {
            Destroy(gameObject);
        }
    }

}
