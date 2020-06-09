using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Name of File: GetCoin
// Purpose: To create the coin pickup and counter system
//Version: Up to Date as of 6/9/2020
//Author: Caraton Dixon (cd3258)
//Dependencies: Unity 3D Editor Components
public class GetCoin : MonoBehaviour
{
    public int coins = 0;
    public Text currencyCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // set coin text to [coins]¢ every frame
        currencyCounter.text = coins + "¢";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if Player collides with coin
        if (collision.gameObject.CompareTag("Coin"))
        {
            // add 1 to coin and destroy the coin object
            coins = coins + 1;
            Destroy(collision.gameObject);
        }
    }
}
