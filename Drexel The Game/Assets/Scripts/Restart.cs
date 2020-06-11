using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Name of File: Restart
// Purpose: To restart the game from the very beginning
//Version: Up to Date as of 6/9/2020
//Author: Caraton Dixon (cd3258)
//Dependencies: Unity 3D Editor Components
public class Restart : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if enter is pressed
        if (Input.GetKeyDown("return"))
        {
            // load next scene
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
    }
}
