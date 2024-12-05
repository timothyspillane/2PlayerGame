using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] Vector2 TargetPosition;
    [SerializeField] float speed;
    private int goal = 0;
    private Vector2 StartingPosition;
    private Vector2 moveDirection;
    private Vector2 currentTarget;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartingPosition = transform.position;
        currentTarget = TargetPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float dist1 = Vector2.Distance(transform.position, currentTarget);
        if (dist1 < 0.5f && goal == 0)
        {
            goal = 1;
            currentTarget = StartingPosition;

        } else if (dist1 < 0.5f && goal == 1)
        {
            goal = 0;
            currentTarget = TargetPosition;
        }
        moveDirection = (currentTarget - rb.position).normalized;
        rb.velocity = (moveDirection * speed);
    }
}
