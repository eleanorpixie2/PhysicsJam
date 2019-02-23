using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTimerScript : MonoBehaviour
{
    // Start is called before the first frame update

    float timesincelastcall;
    public Animator animator;

    public Animation MyAnimation;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timesincelastcall += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Cooldown Started");
            animator.SetBool("FullTimer", false);
            animator.SetTrigger("KeyPressedArrow");

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("Cooldown Started");
            animator.SetBool("FullTimer", false);
            animator.SetTrigger("KeyPressedArrow");

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("Cooldown Started");
            animator.SetBool("FullTimer", false);
            animator.SetTrigger("KeyPressedArrow");

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Cooldown Started");
            animator.SetBool("FullTimer", false);
            animator.SetTrigger("KeyPressedArrow");

        }

        animator.SetFloat("Time", timesincelastcall);

        if (timesincelastcall >= 10)
        {
            animator.SetBool("FullTimer", true);
            timesincelastcall = 0;
        }
    }
}
