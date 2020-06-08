﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        float xTarget =
    trackingTarget.position.x + xOffset;
        float yTarget =
    trackingTarget.position.y + yOffset;

        float xNew =
    Mathf.Lerp(transform.position.x, xTarget, Time.deltaTime * followSpeed);
        float yNew =
    Mathf.Lerp(transform.position.y, yTarget, Time.deltaTime * followSpeed);
        transform.position = new
    Vector2(xNew, yNew);

    }
}
