using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
