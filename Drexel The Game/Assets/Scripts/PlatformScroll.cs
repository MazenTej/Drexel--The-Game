using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Name of File: PlatformScroll
// Purpose: To move the platforms across the level
//Version: Up to Date as of 6/9/2020
//Author: Caraton Dixon (cd3258)
//Dependencies: Unity 3D Editor Components
public class PlatformScroll : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        // every frame: move the platform left multiplied by the frame speed and the speed set for the platform  
        transform.Translate(Vector2.left * Time.deltaTime * speed);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if the platform collides with an object with the tag "ObjectBoundary"
        if (collision.gameObject.CompareTag("ObjectBoundary"))
        {
            // destroy Platform
            Destroy(gameObject);
        }// used in Level 5, if the object touches a certain barrier (tagged "Speed1")
        if (collision.gameObject.CompareTag("Speed1"))
        {
            // speeds up ferrari with the player
            speed = -6;
        }
    }

}
