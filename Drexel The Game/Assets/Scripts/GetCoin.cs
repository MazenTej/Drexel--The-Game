using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
