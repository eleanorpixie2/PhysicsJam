using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    public void Start()
    {
        
    }
    // Start is called before the first frame update
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

            if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
            {
                SceneManager.LoadScene(nextSceneIndex);

            }
        }
       
    }




}
