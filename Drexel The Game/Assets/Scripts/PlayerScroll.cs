using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Name of File: PlayerScroll
// Purpose: To move the player right (utilized in Level 5 Market Street Part 2)
//Version: Up to Date as of 6/9/2020
//Author: Caraton Dixon (cd3258)
//Dependencies: Unity 3D Editor Components
public class PlayerScroll : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // Move the object left * speed variable * fps rate
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if the object touches a certain barrier (tagged "Speed2")
        if (collision.gameObject.CompareTag("Speed2"))
        {
            // speed up the object's movement (going right)
            speed = -6;
        }
    }
}
