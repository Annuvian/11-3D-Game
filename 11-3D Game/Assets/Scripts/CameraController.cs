﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private const float Y_ANGLE_MIN = 15.0f;
    private const float Y_ANGLE_MAX = 50.0f;
    private const float DISTANCE_MIN = .5f;
    private const float DISTANCE_MAX = 5f;
    public Transform lookAt;
    public Transform camTransform;
    private Camera cam;
    private float distance = 1.0f;
    private float currentX = 5.0f;
    private float currentY = 2.0f;
    private float sensitivityX = 10.0f;
    private float sensitivityY = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        camTransform = transform;
        cam = Camera.main;
    }

    private void Update()
    {
        currentX += Input.GetAxis("Mouse X") * sensitivityX;
        currentY -= Input.GetAxis("Mouse Y") * sensitivityY;
        distance -= Input.GetAxis("Mouse ScrollWheel");
        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
        distance = Mathf.Clamp(distance, DISTANCE_MIN, DISTANCE_MAX);
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
    }
}