using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingController : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;
    float maxVelocity = 10;

    public float runSpeed = 0.5f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Gives a value between -1 and 1
        horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left

    }

    void FixedUpdate()
    {
        body.velocity = body.velocity + new Vector2(horizontal * runSpeed, 0);
        if (body.velocity.x > maxVelocity)
        {
            body.velocity = new Vector2(maxVelocity, body.velocity.y);
        } else if(body.velocity.x < (-1* maxVelocity))
        {
            body.velocity = new Vector2((-1*maxVelocity), body.velocity.y);
        }
    }
}
