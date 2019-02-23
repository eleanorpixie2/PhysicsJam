using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolDownTimer : MonoBehaviour
{

    public Animator animator;

    public Animation MyAnimation;

    public int Check = 0;
    public float cooldownTime = .09f;
    private float nextfire = 0f;
    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
         
    }

        // Update is called once per frame
    void Update()
    {
        time = Time.time;

        MyAnimation = GetComponent<Animation>();
        if (time > nextfire)
        {
            //Making Pie Empty
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                print("Cooldown Started");
                animator.SetBool("FullTimer", false);
                animator.SetTrigger("KeyPressedArrow");

            }
            nextfire = time + cooldownTime;
            //Filling of the Pie
           
            animator.SetFloat("Time", nextfire);
            Debug.Log("Time: " + time);
            Debug.Log("nextfire: " + nextfire);

        }
        //Once time has passed, set the pie to full
        if (nextfire > 10)
            {
                animator.SetBool("FullTimer", true);
                nextfire = 0f;
                time = 0f;
            }
    }

    


}
