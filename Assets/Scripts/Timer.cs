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

       // StartCoroutine(StartTimer());
        //
        //if ()
        //{

        //}
        //this.GetComponent<SpriteRenderer>().sprite = NeoNumber1;

        //this.GetComponent<SpriteRenderer>().sprite = NeoNumber1;

        //this.GetComponent<SpriteRenderer>().sprite = NeoNumber1;

        //Replace when value is changed with assert





    }

        /* 
        if (GameOver)
        {
        TimerValue.SetActive(False);
        }
         */
   }
}
