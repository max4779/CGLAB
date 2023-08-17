using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MousePoint : MonoBehaviour
{
    private Camera camera;
    private RectTransform mousepoint;

    void Start()
    {
        camera = Camera.main;
        mousepoint = GetComponentInChildren<Image>().rectTransform; 
    }

    
    void Update()
    {
        Vector3 cameraPosition = camera.transform.position;
        Vector3 cameraForward = camera.transform.forward;
        Vector3 PointPosition = cameraPosition + cameraForward;
        Vector2 screenPoint = camera.WorldToScreenPoint(PointPosition);
        mousepoint.position = screenPoint;
    }
}
