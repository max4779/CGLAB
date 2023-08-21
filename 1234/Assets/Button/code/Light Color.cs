using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLightColor : MonoBehaviour
{
    public Color32 LightBlue = new Color32(185, 217, 212, 255);
    public Color32 Pink = new Color32(238, 190, 190, 255);
    public Color[] colors;

    int colorIndex = 0;
    bool enableColorChange = false;

    List<Light> lights = new List<Light>();

    void Start()
    {
        // LightBlue�� Pink�� colors �迭�� �߰�
        colors = new Color[] { Color.red, Color.blue, Color.green, LightBlue, Pink };

        // ��� Light ������Ʈ�� ã�Ƽ� ����Ʈ�� �߰�
        Light[] lightComponents = FindObjectsOfType<Light>();
        foreach (Light light in lightComponents)
        {
            lights.Add(light);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            enableColorChange = true; // ���콺 Ŭ�� �� ���� ���� Ȱ��ȭ
        }
    }

    void OnMouseDown()
    {
        if (enableColorChange)
        {
            ChangeColor();
            enableColorChange = false; // ���� ���� �� �ٽ� ��Ȱ��ȭ
        }
    }

    void ChangeColor()
    {
        // ���� �������� ����
        colorIndex = (colorIndex + 1) % colors.Length;

        // ��� ������ ������ ����
        foreach (Light light in lights)
        {
            light.color = colors[colorIndex];
        }
    }
}
