using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class image : MonoBehaviour
{
    public Material[] cubematerial;
    public GameObject question;

    private int NumberOfTest = -1;

    private float time = 0.0f;
    public float waitingTime=2.0f;

    private int score=0;
    public Text scoreOutput;
    private int count = 0;
    private int click = 0;

    bool start=false;
    private void Start()
    {
        UpdateScoreText();
    }

    void Update()
    {
        if (start)
        {
            time += Time.deltaTime;

            if (time >= waitingTime)
            {
                Changeimage();
                time = 0.0f;
            }
        }
    }



    public void OnMouseDown()
    {
        
        start = true;
        if (NumberOfTest == 3 && click == 0){
            score++;
            click++;
            UpdateScoreText(); 
        }
        if (NumberOfTest == 1 && click == 0)
        {
            score++;
            click++;
            UpdateScoreText();
        }
    }

    public void Changeimage()
    {
        click=0;
        Renderer renderer = question.GetComponent<Renderer>();
        if (renderer != null && count != cubematerial.Length)
        {
            count++;
            NumberOfTest = (NumberOfTest + 1) % cubematerial.Length;
            renderer.material = cubematerial[NumberOfTest];
        }
    }

    void UpdateScoreText()
    {
        scoreOutput.text = "Score : " + score.ToString();
    }
}
