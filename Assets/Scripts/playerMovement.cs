using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
 
    public Rigidbody2D rb2d;

    public float speed;
    private float maxSpeed;
    public float jumpSpeed;
    private bool isJumping;

    private bool moveRight;
    private bool moveLeft;
    private bool jump;

    void Start()
    {
        maxSpeed = 200;
        rb2d = gameObject.GetComponent<Rigidbody2D>();

    }
    void Update()
    {

        moveRight = Input.GetKey(KeyCode.D);
        moveLeft = Input.GetKey(KeyCode.A);
        jump = Input.GetKey(KeyCode.Space);

    }

    void FixedUpdate()
    {
        keyController();

    }

    void keyController()
    {

        float momentum = Mathf.Abs(rb2d.velocity.x);

        if (moveRight && !isJumping && momentum <= maxSpeed)
        {
            rb2d.AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);
        }
        if (moveLeft && !isJumping && momentum <= maxSpeed)
        {
            rb2d.AddForce(new Vector2(-speed, 0), ForceMode2D.Impulse);
        }
        if (jump && !isJumping)
        {
            Debug.Log("Jump");
            rb2d.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
        }
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        //Is player on ground
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = false;
            Debug.Log(isJumping);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        //Is player on ground
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = true;
            Debug.Log(isJumping);
        }
    }
}