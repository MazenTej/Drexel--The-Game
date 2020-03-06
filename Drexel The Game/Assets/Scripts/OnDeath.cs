using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnDeath : MonoBehaviour
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
    IEnumerator timer()
    {
        // wait for 1 second
        yield return new WaitForSeconds(1.0f);
        // Load the entered scene in Unity
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if Player collides with Death Boundary
        if ((collision.gameObject.CompareTag("Death")) || (collision.gameObject.CompareTag("Hazard")))
        {
            // start timer function
            StartCoroutine(timer());
        }
    }
}
