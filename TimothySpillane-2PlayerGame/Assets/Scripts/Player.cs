using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode playerUp;
    [SerializeField] KeyCode playerRight;
    [SerializeField] KeyCode playerLeft;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(playerUp))
        {
            LayerMask layers = LayerMask.GetMask("Ground");
            RaycastHit2D cast = Physics2D.Raycast(transform.position, Vector2.down, .51f, layers);
            if (cast)
            {
                rb.velocity = new Vector2(rb.velocity.x, 5f);
            }
            
        }
        if (Input.GetKey(playerRight))
        {
            rb.velocity = new Vector2(5f, rb.velocity.y);
        }
        if (Input.GetKey(playerLeft))
        {
            rb.velocity = new Vector2(-5f, rb.velocity.y);
        }
    }
}
