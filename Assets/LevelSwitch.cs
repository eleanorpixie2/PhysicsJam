using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSwitch : MonoBehaviour
{
    //Buttons used in menu
    public Button StartButton1;
    public Button Instructions;
    public Button ExitButton;
    public Button MenuButton;
    public Button CreditsButton;
    public Button RestartButton;


    // Use this for initialization
    void Start()
    {
        //dont destroy this game object
        DontDestroyOnLoad(this);

        //set default resolution
        Camera.main.aspect = (5f / 4f);
        //create code for buttons, buttons only work if there is an object attached to it
        if (StartButton1 != null)
        {
            Button btn = StartButton1.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
        }
        if (Instructions != null)
        {
            Button btn = Instructions.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick5);
        }
        if (ExitButton != null)
        {
            Button btn1 = ExitButton.GetComponent<Button>();
            btn1.onClick.AddListener(TaskOnClick1);
        }
        if (MenuButton != null)
        {
            Button btn2 = MenuButton.GetComponent<Button>();
            btn2.onClick.AddListener(TaskOnClick2);
        }
        if (CreditsButton != null)
        {
            Button btn3 = CreditsButton.GetComponent<Button>();
            btn3.onClick.AddListener(TaskOnClick3);
        }
        if (RestartButton != null)
        {
            Button btn4 = RestartButton.GetComponent<Button>();
            btn4.onClick.AddListener(TaskOnClick4);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    //loads instructions
    void TaskOnClick()
    {
        
        SceneManager.LoadScene("Instructions");
    }

    //exits game
    void TaskOnClick1()
    {
        
        Application.Quit();
    }

    //returns to start menu
    void TaskOnClick2()
    {
        
        SceneManager.LoadScene("MainMenu");
    }

    //loads credits
    void TaskOnClick3()
    {
        
        SceneManager.LoadScene("Credits");
    }

    //loads checkpoint
    void TaskOnClick4()
    {
        
        SceneManager.LoadScene("Level1");
        
    }

    //loads game
    public static void TaskOnClick5()
    {
        SceneManager.LoadScene("Level1");
    }

    //loads gameover scene
    public static void GameOver()
    {
        SoundManagerScript.PlaySound("playerDies");
        SceneManager.LoadScene("Lose");
    }
}





