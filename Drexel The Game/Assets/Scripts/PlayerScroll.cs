using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Speed2"))
        {
            speed = -6;
        }
    }
}
