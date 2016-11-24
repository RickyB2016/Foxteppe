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

    public static float vSpeed, maxVspeed = -7, jumpCount = 1, maxJumpCount = 1, maxAirDashCount = 1;

    public float hSpeed = 0, yVel, airDashCount = 1, airDashVel = 60;

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

            vSpeed = 8;

            jumpCount--;

        }

        // Horizontal Movement

        hSpeed = (airDashVel / 10) * Math.Sign(Input.GetAxisRaw("Horizontal"));

        // Gravity

        if (onGround)
        {

            vSpeed = 0;

            rb.velocity = new Vector2(hSpeed, 0);

        }
        else
        {

            vSpeed -= 0.4f;

            if (vSpeed < maxVspeed)
            {

                vSpeed = maxVspeed;

            }

            rb.velocity = new Vector2(hSpeed, vSpeed);

        }

        if (!onGround && Input.GetKeyDown(KeyCode.X) && airDashCount > 0 && (Input.GetAxisRaw("Horizontal") != 0))
        {

            vSpeed = 1;

            airDashVel = 140;

            airDashCount--;

        }

        if (airDashVel > 60)
        {

            airDashVel--;

        }

        yVel = rb.velocity.y;

    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (!onGround && rb.velocity.y < 0 && col.tag == "Solid")
        {

            onGround = true;

            jumpCount = maxJumpCount;

            airDashCount = maxAirDashCount;

            airDashVel = 60;

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
