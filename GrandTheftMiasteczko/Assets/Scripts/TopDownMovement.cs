using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopDownMovement : MonoBehaviour
{
    Rigidbody2D body;

    public Text kapitolText;
    public Text lewiatanText;
    public Text babilonText;
    public Animator animator;
    public SpriteRenderer renderer;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;

    public float runSpeed = 10.0f;
    private bool isFacingRight = false;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Gives a value between -1 and 1
        horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
        vertical = Input.GetAxisRaw("Vertical"); // -1 is down
    }
    


    void FixedUpdate()
    {
        if (horizontal > 0 && !isFacingRight)
        {
            renderer.flipX = true;
            isFacingRight = !isFacingRight;
        }
        if (horizontal < 0 && isFacingRight)
        {
            renderer.flipX = false;
            isFacingRight = !isFacingRight;
        }
        if (horizontal != 0 && vertical != 0) // Check for diagonal movement
        {
            // limit movement speed diagonally, so you move at 70% speed
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
        
        animator.SetFloat("player speed", (Mathf.Abs(horizontal)+Mathf.Abs(vertical)));
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
        kapitolText.text = "Kapitol: " + PlayerStats.kapitol.ToString();
        lewiatanText.text = "Lewiatan: " + PlayerStats.lewiatan.ToString();
        babilonText.text = "Babilon: " + PlayerStats.babilon.ToString();
    }
}
