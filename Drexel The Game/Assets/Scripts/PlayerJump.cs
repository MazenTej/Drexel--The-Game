using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Name of File: PlayerJump
// Purpose: To establish all player controls
//Version: Up to Date as of 6/9/2020
//Author: Caraton Dixon (cd3258)
//Dependencies: Unity 3D Editor Components
public class PlayerJump : MonoBehaviour
{
    public Rigidbody2D playerRigi;
    public float jumpForce;
    public int numOfJumps = 2;
    public int jumpCounter = 2;
    public int powerup = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if the user presses "w", "spacebar", or "upArrow" while the jumpCounter is greater than 0
        if ((Input.GetKeyDown("w") || Input.GetKeyDown("space") || Input.GetKeyDown("up")) && jumpCounter > 0)
        {
            // set player's rigidbody upwards velocity (Vector for 2D object) equal to the public float jumpForce. Then subract jumps by 1
            // a.k.a. allow it to jump and subtract a jump from it's jump counter (double jump)
            playerRigi.velocity = new Vector2(0, jumpForce);
            jumpCounter = jumpCounter - 1;
        }
        
        // if the powerup counter = 0
        if (powerup == 0)
        {
            // set the maximum number of jumps to 2
            numOfJumps = 2;
        }
        if (powerup > 0)
        {
            numOfJumps = 3;
            if (jumpCounter == 0)
            {
                powerup = powerup - 1;
                jumpCounter = -1;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if the Player collides with a platform with the tag "platform"
        if (collision.gameObject.CompareTag("Platform"))
        {
            // reset jump counter to 2 (numOfJumps)
            jumpCounter = numOfJumps;
        }
        // if the Player collides with a hazard (ex. spikes, traps, etc.)
        if ((collision.gameObject.CompareTag("Hazard")) || collision.gameObject.CompareTag("Death"))
        {
            // destroy Player by disabling the box collider and making him invisible
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }

    }

    
}
