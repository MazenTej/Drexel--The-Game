using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Name of File: SpriteTextScript
// Purpose: To activate text objects in the various timeslots in the tutorial level
//Version: Up to Date as of 6/9/2020
//Author: Caraton Dixon (cd3258)
//Dependencies: Unity 3D Editor Components

public class SpriteTextScript : MonoBehaviour
{
    public int Active = 0;
    public Text SpikeText;
    public Text FText;
    public Text CoinText;
    public Text AText;
    public Text EndText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if Active equals 0
        if (Active == 0)
        {
            // set all texts to invisible
            SpikeText.GetComponent<Text>().enabled = false;
            FText.GetComponent<Text>().enabled = false;
            CoinText.GetComponent<Text>().enabled = false;
            AText.GetComponent<Text>().enabled = false;
            EndText.GetComponent<Text>().enabled = false;
        }

        // if Active is 1
        if (Active == 1)
        {
            // set SpikeText to visible
            SpikeText.GetComponent<Text>().enabled = true;
        }

        // if Active is 2
        if (Active == 2)
        {
            // set Ftext to visible
            FText.GetComponent<Text>().enabled = true;
        }

        // if Active is 3
        if (Active == 3)
        {
            // set CoinText to visible
            CoinText.GetComponent<Text>().enabled = true;
        }

        // if Active is 4
        if (Active == 4)
        {   // set Atext to visible
            AText.GetComponent<Text>().enabled = true;
        }

        // if Active is 5
        if (Active == 5)
        {
            // set EndText to visible
            EndText.GetComponent<Text>().enabled = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if Player collides with Activate1
        if (collision.gameObject.CompareTag("Activate1"))
        {
            // set Active to 1
            Active = 1;
        }

        // if Player collides with Activate2
        if (collision.gameObject.CompareTag("Activate2"))
        {
            // set Active to 2
            Active = 2;
        }

        // if Player collides with Activate3
        if (collision.gameObject.CompareTag("Activate3"))
        {
            // set Active to 3
            Active = 3;
        }

        // if Player collides with Activate4
        if (collision.gameObject.CompareTag("Activate4"))
        {
            // set Active to 4
            Active = 4;
        }

        // if Player collides with Activate5
        if (collision.gameObject.CompareTag("Activate5"))
        {
            // set Active to 5
            Active = 5;
        }

        // if Player collides with Deactivate
        if (collision.gameObject.CompareTag("Deactivate"))
        {
            // set Active to 0
            Active = 0;
        }
    }
    
}
