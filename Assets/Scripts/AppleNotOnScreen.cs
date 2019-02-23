using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleNotOnScreen : MonoBehaviour
{
    bool GroupOffScreen = false;
   // public List<GameObject> Apples;
    SpawnAmount Spawn_Amount;
    // Start is called before the first frame update
    void Start()
    {
        Spawn_Amount = GameObject.FindGameObjectWithTag("SpawnCounter").GetComponent<SpawnAmount>();
        if (Spawn_Amount.SpawnCount < Spawn_Amount.MaxSpawnCount)
        {
            Spawn_Amount.SpawnCount++;
        }
        else if(Spawn_Amount.SpawnCount == Spawn_Amount.MaxSpawnCount)
        {
            Destroy(this);
        }
    }

    void Update()
    {
        OffScreen();
    }

    void OffScreen()
    {

        //foreach (GameObject Apple in Apples)
        //{
        //    Movement ap = Apple.GetComponent<Movement>();
        //    if (ap.IsOffScreen)
        //    {

        //        //GroupOffScreen = true;
        //    }
        //    else
        //    {
        //        //GroupOffScreen = false;
        //        break;
        //    }
        //}

        if (GroupOffScreen)
        {
            Spawn_Amount.SpawnCount--;
            Destroy(this.gameObject);
        }

    }
}
