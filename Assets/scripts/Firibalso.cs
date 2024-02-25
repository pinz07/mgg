﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firibalso : MonoBehaviour
{
    public Transform TargetPoint;
    public Camera cameraLink;
    public float targetInSkyDistance;
    
    void Update()
    {
        var ray = cameraLink.ViewportPointToRay(new Vector3(0.5f, 0.7f, 0));

        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            TargetPoint.position = hit.point;
        }
        else
        {
            TargetPoint.position = ray.GetPoint(targetInSkyDistance);
        }

        transform.LookAt(TargetPoint.position);
    }
}
