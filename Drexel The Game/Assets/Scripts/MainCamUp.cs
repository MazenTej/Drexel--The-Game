using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Name of File: MainCamUp
// Purpose: To change the camera position to move upwards
//Version: Up to Date as of 6/9/2020
//Author: Andy Portillo (ajp424)
//Dependencies: Unity 3D Editor Components
public class MainCamUp : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // every frame move object up by speed variable * fps
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }
}
