using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public Rigidbody2D playerRigi;
    public float jumpForce;
    public int numOfJumps = 2;
    private int jumpCounter = 2;
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
        if (collision.gameObject.CompareTag("Hazard"))
        {
            // destroy Player
            Destroy(gameObject);
        }

    }
}
