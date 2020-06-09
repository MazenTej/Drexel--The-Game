using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Name of File: ReachEnd
// Purpose: To switch levels when the player reaches the end of a level
//Version: Up to Date as of 6/9/2020
//Author: Caraton Dixon (cd3258)
//Dependencies: Unity 3D Editor Components
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
