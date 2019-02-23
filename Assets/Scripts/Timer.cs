using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //private bool showImageYes = false;





    //Insert: <Asset Folder> <name>;
    //private 
   
    private float timerValueCurrent; 
    internal IEnumerator StartTimer(float timerValueStart = 0)
    {
        timerValueCurrent = timerValueStart;

        //name = GameObject.Find ("<Name of asset>").GetComponent<Asset Folder> ();
        while (timerValueCurrent < 0 || timerValueCurrent == 0)
        {
            //Delete this when assets are done.
            Debug.Log(timerValueCurrent); 

           //while number asset name is less than 9, have 1 be next to asset. 
            //After 1 second, replace asset.
            yield return new WaitForSeconds(1.0f); 

            ++timerValueCurrent;
        }
    }
    void Start()
    {
        //name = GameObject.Find ("<Name of asset>").GetComponent<Asset Folder> (); //Only for assets.

    }
    void Update()
    {
        StartCoroutine(StartTimer());
        //
        if
        this.GetComponent<SpriteRenderer>().sprite = NeoNumber1;

        this.GetComponent<SpriteRenderer>().sprite = NeoNumber1;

        this.GetComponent<SpriteRenderer>().sprite = NeoNumber1;

        //Replace when value is changed with assert





    }
}
