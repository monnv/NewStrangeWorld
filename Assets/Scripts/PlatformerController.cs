﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerController : MonoBehaviour
{

    //Speed of character movement and height of the jump. Set these values in the inspector.
    public float speed;
    public float jumpHeight;

    //Assigning a variable where we'll store the Rigidbody2D component.
    private Rigidbody2D rb;

    private bool onGround;
    private bool canJump;

    public Animator char_animator;
    public AudioClip impact;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //Sets our variable 'rb' to the Rigidbody2D component on the game object where this script is attached.
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        //Check if the player is on the ground. If we are, then we are able to jump.
        if (onGround == true)
        {
            canJump = true;
        }
        //If we're able to jump and the player has pressed the space bar, then we jump!
        if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            rb.velocity = Vector2.up * jumpHeight;
        }

        //calls the character animator with the movement script below. 
        char_animator.SetFloat("speed", rb.velocity.x);


        //Movement code for left and right arrow keys.
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(+speed, rb.velocity.y);
        }
        //ELSE if we're not pressing an arrow key, our velocity is 0 along the X axis, and whatever the Y velocity is (determined by jump)
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //If we collide with an object tagged "ground" then our jump resets and we can now jump.
        if (collision.gameObject.tag == "ground")
        {
            onGround = true;
            print(onGround);
            print("We grounded now");
            //print statements print to the Console panel in Unity. 
            //This will print the value of onGround, which is a boolean, so either True or False.
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //If we exit our collision with the "ground" object, then we are unable to jump.
        if (collision.gameObject.tag == "ground")
        {
            onGround = false;
            print(onGround);
        }
    }
}
