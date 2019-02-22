using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleNotOnScreen : MonoBehaviour
{
    bool GroupOffScreen = false;
    public List<GameObject> Apples;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        OffScreen();
    }

    void OffScreen()
    {
        foreach (GameObject Apple in Apples)
        {
            Movement ap = Apple.GetComponent<Movement>();
            if (ap.IsOffScreen)
            {
                Debug.Log("1");
                GroupOffScreen = true;
            }
            else
            {
                Debug.Log("2");
                GroupOffScreen = false;
                break;
            }
        }
        if (GroupOffScreen)
        {
            Destroy(this.gameObject);
        }
    }
}
