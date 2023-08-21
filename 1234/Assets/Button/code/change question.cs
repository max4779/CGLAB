using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changequestion : MonoBehaviour
{
    public Material[] cubematerial;
    public GameObject question;

    private int NumberOfTest = -1;

    private float time = 0.0f;
    public float waitingTime = 2.0f;

    private int score = 0;
    public Text scoreOutput;
    private int count = 0;
    private int click = 0;
    private bool alreadystart=false; 

    bool start = false;
    public void startQuestion()
    {
        alreadystart = true;
    }

    void Update()
    {
        if (alreadystart)
        {
            time += Time.deltaTime;

            if (time >= waitingTime)
            {
                Changeimage();
                time = 0.0f;
            }
        }
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            pressTrigger();
            Debug.Log("Left Trigger");
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            pressTrigger();
            Debug.Log("right Trigger");
        }

    }



    public void pressTrigger()
    {
        Debug.Log("presstriger on");
        Debug.Log(NumberOfTest);
        Debug.Log(click);
        if (NumberOfTest == 3 && click == 0)
        {
            score++;
            click++;
            Debug.Log("plus 3");
            UpdateScoreText();
            
        }
        if (NumberOfTest == 1 && click == 0)
        {
            score++;
            click++;
            Debug.Log("plus 1");
            UpdateScoreText();
            
        }
    }

    public void Changeimage()
    {
        click = 0;
        Renderer renderer = question.GetComponent<Renderer>();
        if (renderer != null && count != cubematerial.Length)
        {
            count++;
            NumberOfTest = (NumberOfTest + 1) % cubematerial.Length;
            renderer.material = cubematerial[NumberOfTest];
        }
        else
        {
            alreadystart = false;
        }
    }

    void UpdateScoreText()
    {
        scoreOutput.text = "Score : " + score.ToString();
        Debug.Log("Score : " + score.ToString());
    }

}
