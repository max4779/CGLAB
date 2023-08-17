using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    void Start()
    {
        Debug.Log("Hello Unity");
        int level = 10;
        float health = 10.5f;
        string name = "Hero";
        bool check = false;


        Debug.Log("What is your name?");
        Debug.Log(name);
        Debug.Log("너 레벨 몇이야?");
        Debug.Log(level);
        Debug.Log("너 체력이 몇이야?");
        Debug.Log(health);

        List<string> item = new List<string>();
        item.Add("어쩔");
        item.Add("티비");

        Debug.Log(item[0]);
    }


}
