using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReachEnd : MonoBehaviour
{
    public string sceneName;
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
            // if Player collides with End Boundary
            if (collision.gameObject.CompareTag("End"))
            {
            // Load the entered scene in Unity
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
            }
        }
    }
