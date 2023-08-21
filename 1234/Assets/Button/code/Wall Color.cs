using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeWallColor : MonoBehaviour
{
    public Color32 LightBlue = new Color32(185, 217, 212, 255);
    public Color32 Pink = new Color32(238, 190, 190, 255);
    public Color[] colors;

    int colorIndex = 0;

    Renderer wallRenderer;
    bool EnableChange = false;



    void Start()
    {
        colors = new Color[] { Color.red, Color.blue, Color.green, LightBlue, Pink };

        GameObject wall = GameObject.Find("Wall");

        if (wall != null)
        {
            wallRenderer = wall.GetComponent<Renderer>();
        }

    }

    void Update()
    {

    }

    public void TriggerOn(Collider other)
    {
        ChangeColor();
    }

    void ChangeColor()
    {
        // 다음 색상으로 변경
        colorIndex = (colorIndex + 1) % colors.Length;

        // WallF과 WallL의 렌더러 컴포넌트에 색상 변경 적용
        if (wallRenderer != null)
        {
            wallRenderer.material.color = colors[colorIndex];
        }
    }
}