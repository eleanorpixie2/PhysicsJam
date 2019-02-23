using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject TimerValue;

    void Start()
    {
        //Alt Code: TimerValue = GameObject.Find("TimerValue");
        TimerValue = GameObject.Find("TimerValue");

        //TimerValue = GetComponent<GameObject>();
        TimerValue.SetActive(true);
    }
    void Update()
    {
        /* 
        if (GameOver)
        {
        TimerValue.SetActive(False);
        }
         */
   }
}
