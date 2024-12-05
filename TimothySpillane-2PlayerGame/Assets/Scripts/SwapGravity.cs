using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapGravity : MonoBehaviour
{
    public float gravity;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale *= gravity;
    }
}
