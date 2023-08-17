using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeWallColor : MonoBehaviour
{
    public Color32 LightBlue = new Color32(185, 217, 212, 255);
    public Color32 Pink = new Color32(238, 190, 190, 255);
    public Color[] colors;

    int colorIndex = 0;
    bool enableColorChange = false;

    private Renderer wallRenderer;
    


    void Start()
    {
        // LightBlue와 Pink를 colors 배열에 추가
        colors = new Color[] { Color.red, Color.blue, Color.green, LightBlue, Pink };

        // WallF과 WallL 이름의 GameObject를 찾음
        GameObject changer = GameObject.Find("Wall");
 


        if (changer != null)
        {
            wallRenderer = changer.GetComponent<Renderer>();
        }


    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            enableColorChange = true; // 마우스 클릭 시 색상 변경 활성화
        }
    }

    void OnMouseDown()
    {
        if (enableColorChange)
        {
            ChangeColor();
            enableColorChange = false; // 색상 변경 후 다시 비활성화
        }
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