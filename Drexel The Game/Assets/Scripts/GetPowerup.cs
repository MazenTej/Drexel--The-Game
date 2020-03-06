using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
