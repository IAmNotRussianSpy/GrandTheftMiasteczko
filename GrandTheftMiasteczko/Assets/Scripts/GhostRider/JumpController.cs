using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    public Vector2 jumpHeight;
    public Rigidbody2D player;
    private int jumps = 0;
    public AudioClip boing;
    private AudioSource source;

    // Use this for initialization
    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) 
        {
            if (player.position.y < -3.3)
            {
                jumps = 0;
            }
            if (jumps<2)
            {
                player.AddForce(jumpHeight, ForceMode2D.Impulse);
                source.PlayOneShot(boing);
                jumps++;
            }
        }
        
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Miasteczko");
    }
}