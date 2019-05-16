using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    public Vector2 jumpHeight;
    public Rigidbody2D player;
    private int jumps = 0;

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            if (player.position.y < -3.3)
            {
                jumps = 0;
            }
            if (jumps<2)
            {
                player.AddForce(jumpHeight, ForceMode2D.Impulse);
                jumps++;
            }
        }
        
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Miasteczko");
    }
}