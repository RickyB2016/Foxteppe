using UnityEngine;
using System.Collections;
using System;

/*
 * This script will contain:
 * 
 * Horizontal Movement - DONE
 * Vertical Movement
 * Gravity on the Player
 * Collision Detection through RayCasting
 * Double Jumping
 * Wall Jumping
 * Wall Sliding
 * Air Dashing
 * 
 * This script will not contain:
 * 
 * Player Health
 * Melee Attacking
 * */

public class Player_Movement : MonoBehaviour {

    public float vSpeed, maxVspeed = -7, jumpCount = 1, maxJumpCount = 1, maxAirDashCount = 0;

    public float hSpeed = 0, yVel, airDashCount = 1, airDashVel = 60, velocityY;

    Vector2 prevFrame, currentFrame;

    Rigidbody2D rb;

    RaycastHit downDetection;

    Vector2 groundHit, groundDistance;

    public bool onGround = false;

    void Awake() {

        DontDestroyOnLoad(transform.gameObject);

        rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate() {

        if (Input.GetKeyDown(KeyCode.Z) && jumpCount > 0)
        {

            //Jumping

            //rb.AddForce (-transform.up * 50, ForceMode2D.Impulse);

            onGround = false;

            vSpeed = 8.4f;

            jumpCount--;

        }

        // Horizontal Movement

        hSpeed = (airDashVel / 9.5f) * Math.Sign(Input.GetAxisRaw("Horizontal"));

        // Gravity

        if (onGround)
        {

            vSpeed = 0;

            rb.velocity = new Vector2(hSpeed, 0);

        }
        else
        {

            vSpeed -= 0.3f;

            if (vSpeed < maxVspeed)
            {

                vSpeed = maxVspeed;

            }

            rb.velocity = new Vector2(hSpeed, vSpeed);

        }

        if (!onGround && Input.GetKeyDown(KeyCode.X) && airDashCount > 0 && (Input.GetAxisRaw("Horizontal") != 0))
        {

            vSpeed = 1;

            airDashVel = 130;

            airDashCount--;

        }

        if (airDashVel > 40)
        {

            airDashVel--;

        }

        yVel = rb.velocity.y;

        //VERY IMPORTANT BUG FIXING FEATURE

        if ((rb.velocity.y == -7) && !onGround){


            currentFrame = transform.position;

            if (currentFrame.y == prevFrame.y && rb.velocity.y == -7)
            {

                onGround = true;
                jumpCount = maxJumpCount;


            }

        }

        velocityY = rb.velocity.y;

        prevFrame = transform.position;

    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (!onGround && rb.velocity.y < 0 && col.tag == "Solid")
        {

            onGround = true;

            jumpCount = maxJumpCount;

            airDashCount = maxAirDashCount;

            airDashVel = 55;

        }

        if (col.name == "DJ_Upgrader")
        {

            maxJumpCount = 2;
            Destroy(col.gameObject);

        } if (col.name == "AD_Upgrader")
        {

            maxAirDashCount = 1;
            Destroy(col.gameObject);

        }
    }

    void OnTriggerStay2D(Collider2D stay)
    {

        if (onGround)
        {

        onGround = true;

        }

    }

    void OnTriggerExit2D(Collider2D leave)
    {

        onGround = false;

    }

}
