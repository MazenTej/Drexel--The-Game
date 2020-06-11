using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Name of File: GetPowerup
// Purpose: To establish the effects the game has when a player picks up a powerup (i.e triple jump calculations)
//Version: Up to Date as of 6/9/2020
//Author: Caraton Dixon (cd3258)
//Dependencies: Unity 3D Editor Components
public class GetPowerup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if the object collides with the powerup
        if (collision.gameObject.CompareTag("Powerup"))
        {
            // Destroy powerup
            Destroy(collision.gameObject);
            // set max number of jumps to 3
            gameObject.GetComponent<PlayerJump>().numOfJumps = 3;
            // set powerup counter to 3
            gameObject.GetComponent<PlayerJump>().powerup = 3;
            // add one to jumpCounter
            gameObject.GetComponent<PlayerJump>().jumpCounter += 1;
        }
    }
}
