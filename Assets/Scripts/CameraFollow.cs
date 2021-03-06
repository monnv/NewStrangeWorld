﻿using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //boundaries for camera
    public bool bounds;
    public Vector3 minCameraPos;
    public Vector3 maxCameraPos;

    //target is the object we want the camera to look at
    public Transform player;

    //smoothSpeed adjusts the movement of the camera so it doesn't snap
    public float smoothSpeed = 0.125f;

    //this is the amount the camera is offset from the target
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Camera follows the player with specified offset position
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z); 

        if (bounds)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCameraPos.x, maxCameraPos.x),
                Mathf.Clamp(transform.position.y, minCameraPos.y, maxCameraPos.y),
                Mathf.Clamp(transform.position.z, minCameraPos.z, maxCameraPos.z));
        }
    }
}