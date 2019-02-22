using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour
{ 

    float VerticalInput;
    float HorizontalInput;
    Movement GravityMovement;

    GameObject[] ApplesList;

    // Start is called before the first frame update
    void Start()
    {
        ApplesList = GameObject.FindGameObjectsWithTag("Apple");
    }

    // Update is called once per frame
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
