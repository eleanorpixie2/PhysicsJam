using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewtonScript : MonoBehaviour
{
    float VerticalInput = 0;
    float HorizontalInput = 0;
    bool FlipFlop;
    bool isDead = false;
    GravityScript GetInput;
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        VerticalInput = Input.GetAxis("Vertical");
        HorizontalInput = Input.GetAxis("Horizontal");

        if (VerticalInput > 0)
        {
            FlipAnim();
        }
        else if (VerticalInput < 0)
        {
            FlipAnim();
        }
        else if (HorizontalInput > 0)
        {
            FlipAnim();
        }
        else if (HorizontalInput < 0)
        {
            FlipAnim();
        }
        else
        {
            animator.SetInteger("FlipFlop", 0);
        }
    }

    void FlipAnim()
    {
        if (FlipFlop)
        {
            Debug.Log("Test1");
            animator.SetInteger("FlipFlop", 1);
            FlipFlop = false;
        }
        else if (!FlipFlop)
        {
            Debug.Log("Test2");
            animator.SetInteger("FlipFlop", 2);
            FlipFlop = true;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Dead");
        animator.SetTrigger("isDead");
        LevelSwitch.GameOver();
    }
}
