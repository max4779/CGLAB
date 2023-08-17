using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changequestion : MonoBehaviour
{
    public Material[] cubematerial;
    public GameObject question;

    private int NumberOfTest=0;

    public void OnMouseDown()
    {
        Renderer renderer = question.GetComponent<Renderer>();
        if (renderer != null)
        {
            NumberOfTest = (NumberOfTest + 1) % cubematerial.Length;
            renderer.material = cubematerial[NumberOfTest];
        }
    }
}