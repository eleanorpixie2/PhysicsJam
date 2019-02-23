using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour
{ 

    float VerticalInput = 0;
    float HorizontalInput = 0;
    Movement GravityMovement;

    GameObject[] ApplesList;

    void Start()
    {
        // Finds all apple game objects and adds them to a list
        ApplesList = GameObject.FindGameObjectsWithTag("Apple");
    }

    void Update()
    {
        ApplesList = GameObject.FindGameObjectsWithTag("Apple");

        VerticalInput = Input.GetAxis("Vertical");
        HorizontalInput = Input.GetAxis("Horizontal");

        // If VerticalInput is positive, means gravity is going up.
        if (VerticalInput > 0)
        {
            foreach (GameObject Apple in ApplesList)
            {
                GravityMovement = Apple.GetComponent<Movement>();
                if (GravityMovement.Gravity < 0)
                    GravityMovement.Gravity = -GravityMovement.Gravity;
                Apple.transform.rotation = Quaternion.Euler(0, 0, 0);

                GravityMovement.VerticalDirection = true;
            }
        }
        // If VerticalInput is negative, means gravity is going down.
        if (VerticalInput < 0)
        {
            foreach (GameObject Apple in ApplesList)
            {
                GravityMovement = Apple.GetComponent<Movement>();
                if (GravityMovement.Gravity > 0)
                    GravityMovement.Gravity = -GravityMovement.Gravity;
                Apple.transform.rotation = Quaternion.Euler(0, 0, 180);
                GravityMovement.VerticalDirection = true;
            }
        }

        // If Horizontal is postive, means gravity is going right.
        if (HorizontalInput > 0)
        {
            foreach (GameObject Apple in ApplesList)
            {
                GravityMovement = Apple.GetComponent<Movement>();
                if (GravityMovement.Gravity < 0)
                    GravityMovement.Gravity = -GravityMovement.Gravity;
                Apple.transform.rotation = Quaternion.Euler(0, 0, -90);
                GravityMovement.VerticalDirection = false;
            }
        }
        // If Horizontal is negative, means gravity is going left.
        if (HorizontalInput < 0)
        {
            foreach (GameObject Apple in ApplesList)
            {
                GravityMovement = Apple.GetComponent<Movement>();
                if (GravityMovement.Gravity > 0)
                    GravityMovement.Gravity = -GravityMovement.Gravity;
                Apple.transform.rotation = Quaternion.Euler(0, 0, 90);
                GravityMovement.VerticalDirection = false;
            }
        }
    }
}
