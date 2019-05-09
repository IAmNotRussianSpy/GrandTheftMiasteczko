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
    public bool entered = false;
    float timer = 0;

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
        if (entered)
        {
            //Increment timer
            timer += Time.deltaTime;

            //Load scene if counter has reached the nSecond
            if (timer > interval)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("Miasteczko");
            }
        }
        else
        {
            //Reset timer when it's no longer pointing
            timer = 0;
        }
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

    void OnTriggerEnter2D(Collider2D coll)
    {
        //Debug.Log("lol");
        entered = true;
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        //Debug.Log("lol");
        entered = false;
    }
}
