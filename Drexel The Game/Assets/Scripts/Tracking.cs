using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Name of File: Tracking
// Purpose: To change the camera position to track the player's position
//Version: Up to Date as of 6/9/2020
//Author: Andy Portillo (ajp424)
//Dependencies: Unity 3D Editor Components
public class Tracking : MonoBehaviour
{
    public Transform trackingTarget;
    public int xOffset;
    public int yOffset;
    public int followSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // set object's x position to the target's x position + the offset variable
        float xTarget =
    trackingTarget.position.x + xOffset;
        // set object's y position to the target's y position + the offset variable
        float yTarget =
    trackingTarget.position.y + yOffset;
        // move the object based on the set followSpeed and current fps
        float xNew =
    Mathf.Lerp(transform.position.x, xTarget, Time.deltaTime * followSpeed);
        float yNew =
    Mathf.Lerp(transform.position.y, yTarget, Time.deltaTime * followSpeed);
        transform.position = new
    Vector2(xNew, yNew);

    }
}
