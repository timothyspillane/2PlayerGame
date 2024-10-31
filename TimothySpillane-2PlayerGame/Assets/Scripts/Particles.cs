using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(-1f,1f), Random.Range(0.5f,1f)).normalized * 5f; //launch particles at random speeds
        Destroy(this.gameObject, 2f); // destroy after 2 seconds
    }
}
