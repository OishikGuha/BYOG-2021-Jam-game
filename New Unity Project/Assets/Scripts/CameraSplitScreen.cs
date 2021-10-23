using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraSplitScreen : MonoBehaviour
{
    [SerializeField] Camera sideCam;
    [SerializeField] Camera frontCam;
    [Space]
    [Range(0f, 1f)] public float sideCamThickness;
    [Space]
    [SerializeField] Image splitter;
    float frontCamThickness;
    float frontCamXDis;
    [Space]

    public Image w;
    public Image a;
    public Image s;
    public Image d;

    bool doSplit = false;
    private void Start()
    {
        frontCamThickness = 1f - sideCamThickness;
        frontCamXDis = sideCamThickness;
    }
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
        if (doSplit)
        {
            //Enable splitting
            frontCam.gameObject.SetActive(true);
            sideCam.rect = new Rect(0f, 0f, sideCamThickness, 1f);
            frontCam.rect = new Rect(frontCamXDis, 0f, frontCamThickness, 1f);

            splitter.gameObject.SetActive(true);
            float xPos = sideCamThickness * Screen.width;
            Vector2 splitterPos = new Vector2(xPos, splitter.rectTransform.position.y);
            splitter.rectTransform.position = splitterPos;

            w.gameObject.SetActive(true);
            a.gameObject.SetActive(true);
            s.gameObject.SetActive(true);
            d.gameObject.SetActive(true);
        }
        else
        {
            frontCam.gameObject.SetActive(false);
            sideCam.rect = new Rect(0f, 0f, 1f, 1f);

            splitter.gameObject.SetActive(false);

            w.gameObject.SetActive(false);
            a.gameObject.SetActive(false);
            s.gameObject.SetActive(false);
            d.gameObject.SetActive(false);
        }
    }
}
