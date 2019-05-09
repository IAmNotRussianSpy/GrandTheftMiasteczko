using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ItemDropController : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;
    float maxVelocity = 10;
    private float timeForDrop = 0;
    public float runSpeed = 0.5f;
    private float interval = 2.0f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Gives a value between -1 and 1
        horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
        timeForDrop += Time.deltaTime;
        if(timeForDrop >= interval)
        {
            enabled = false;
        }
    }

    void FixedUpdate()
    {
        timeForDrop = 0;
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
