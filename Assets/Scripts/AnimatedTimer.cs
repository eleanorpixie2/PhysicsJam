using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedTimer : MonoBehaviour
{

    public SpriteRenderer[] numbers;

    public SpriteRenderer[] places;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    float temp;
    // Update is called once per frame
    void FixedUpdate()
    {
        temp = StartTimer();

        ChangeOnePlaces(0, temp);
        ChangeTensPlaces(1, temp);
        ChangeMinsPlaces(2, temp);

    }

    private bool tens;
    private void ChangeOnePlaces(int placesPos, float whichNumber)
    {
        int num = Convert.ToInt32(whichNumber % 9);

        places[placesPos].sprite = numbers[num].sprite;

        if (Convert.ToInt32(whichNumber % 9) == 0)
        {
            tens = true;
        }
    }

    private bool mins;
    private void ChangeTensPlaces(int placesPos, float whichNumber)
    {
        if (tens)
        {
            int num = Convert.ToInt32(whichNumber / 9);
            if (num > 5)
            {
                num = 0;
            }

            places[placesPos].sprite = numbers[num].sprite;
            places[0].sprite = numbers[0].sprite;

            tens = false;

            if (num == 6)
            {
                mins = true;
            }


        }
    }

    private void ChangeMinsPlaces(int placesPos, float whichNumber)
    {
        if (mins)
        {
            int num = Convert.ToInt32(whichNumber / 60);

            places[placesPos].sprite = numbers[num].sprite;
            mins = false;

            if (num == 9)
            {
                mins = true;
            }
        }
    }

    private float StartTimer()
    {
        timer += Time.deltaTime;
        return timer;
    }
}
