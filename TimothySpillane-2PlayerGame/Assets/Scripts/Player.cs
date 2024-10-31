using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode playerUp;
    [SerializeField] KeyCode playerRight;
    [SerializeField] KeyCode playerLeft;
    [SerializeField] float speed;
    [SerializeField] float jumpSpeed;


    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(playerUp))// jump input
        {
            LayerMask layers = LayerMask.GetMask("Ground");
            RaycastHit2D cast = Physics2D.Raycast(transform.position, Vector2.down, .61f, layers);
            if (cast)// if there is ground .61 units below, you can jump
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            }
            
        }
        if (Input.GetKey(playerRight))// if player inputs right, move right
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        if (Input.GetKey(playerLeft))// if player inputs left, move left
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
    }
}
