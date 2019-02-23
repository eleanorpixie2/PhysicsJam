using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    //public static AudioClip playerChange, playerDeath;
    public static AudioClip doChange, doDeath, playMusic;
    static AudioSource audioSrc;
    //bool alive;
    bool alive = true;
    // Use this for initialization
    void Start()
    {
        doChange = Resources.Load<AudioClip>("Gravity_Sound");
        doDeath = Resources.Load<AudioClip>("Squishy_Death");
        playMusic = Resources.Load<AudioClip>("backgroundMusic");
        audioSrc = GetComponent<AudioSource>();
        //bool alive = true;
    }

    // Update is called once per frame
    void Update()
    {
            bool up = Input.GetKeyUp(KeyCode.UpArrow);
            if (up)
                PlaySound("changeGravity");
            bool down = Input.GetKeyUp(KeyCode.DownArrow);
            if (down)
                PlaySound("changeGravity");
            bool right = Input.GetKeyUp(KeyCode.RightArrow);
            if (right)
                PlaySound("changeGravity");
            bool left = Input.GetKeyUp(KeyCode.LeftArrow);
            if (left)
                PlaySound("changeGravity");
            
        
            
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "changeGravity":
                audioSrc.PlayOneShot(doChange);
                break;
            case "playerDies":
                audioSrc.PlayOneShot(doDeath);
                break;
            case "musicStart":
                audioSrc.PlayOneShot(playMusic);
                break;
        }
    }
}
