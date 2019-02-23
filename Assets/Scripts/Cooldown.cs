using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooldown : MonoBehaviour
{
    public float cooldownTime = 2.0f;

	private float nextFireTime = 0.0f;

	private void FixedUpdate()
	{

        //VerticalInput = Input.GetAxis("Vertical");
        //HorizontalInput = Input.GetAxis("Horizontal");

        
        if(Time.time > nextFireTime)
		{
			Debug.Log("Next Fire: " + nextFireTime);
			Debug.Log("Time: " + Time.time);
		
			// If VerticalInput is positive, means gravity is going up.
			if (Input.GetKeyUp(KeyCode.UpArrow))
			{
				nextFireTime = Time.time + cooldownTime;
			}
		

		
			// If VerticalInput is negative, means gravity is going down.
			if (Input.GetKeyUp(KeyCode.DownArrow))
			{
				nextFireTime = Time.time + cooldownTime;
			}
		

		
			// If Horizontal is postive, means gravity is going right.
			if (Input.GetKeyUp(KeyCode.RightArrow))
			{
				nextFireTime = Time.time + cooldownTime;
			}
		

		
			// If Horizontal is negative, means gravity is going left.
			if (Input.GetKeyUp(KeyCode.LeftArrow))
			{
				nextFireTime = Time.time + cooldownTime;
			}
		}
	}
}
