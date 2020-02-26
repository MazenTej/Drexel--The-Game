using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if the platform collides with an object with the tag "ObjectBoundary"
        if (collision.gameObject.CompareTag("ObjectBoundary"))
        {
            // destroy Platform
            Destroy(gameObject);
        }
    }

}
