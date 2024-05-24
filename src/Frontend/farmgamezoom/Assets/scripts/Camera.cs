using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public Camera mainCamera;
    public float zoomedFieldOfView = 30f;
    private float defaultFieldOfView;

    void Start()
    {
        defaultFieldOfView = mainCamera.fieldOfView;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            ZoomIn();
        }
        if (Input.GetMouseButtonUp(1))
        {
            ZoomOut();
        }
    }

    void ZoomIn()
    {
        mainCamera.fieldOfView = zoomedFieldOfView;
    }

    void ZoomOut()
    {
        mainCamera.fieldOfView = defaultFieldOfView;
    }
}
