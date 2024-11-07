using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class LauchButton : MonoBehaviour
{
    [SerializeField] Vector2 lauchDirection;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Box"))
        {
            collision.GetComponent<Rigidbody2D>();
        }
    }
   
}