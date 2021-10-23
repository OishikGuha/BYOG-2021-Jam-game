using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSplitScreen : MonoBehaviour
{
    [SerializeField] Camera sideCam;
    [SerializeField] Camera frontCam;
    [Space]
    [Range(0f, 1f)] public float sideCamThickness;

    float frontCamThickness;
    float frontCamXDis;

    bool doSplit = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            doSplit = !doSplit;
        }
        HandleSplit();
    }

    private void HandleSplit()
    {
        
    }
}
