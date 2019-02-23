using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Gravity = 5.8f;
    public bool VerticalDirection = true;

   
    public bool IsOffScreen = true;

    public bool intialChange = false;
    
    Rigidbody2D rbApple;

    // Start is called before the first frame update
    void Start()
    {
        rbApple = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (VerticalDirection)
        {
            rbApple.velocity = new Vector2(0, Gravity);
            print(rbApple.velocity);
        }
        if (!VerticalDirection)
        {
            rbApple.velocity = new Vector2(Gravity, 0);
        }

        OffCamera();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!intialChange)
        {
            if (col.tag == "SpawnLeft")
            {
                VerticalDirection = false;
                intialChange = true;
            }
            else if (col.tag == "SpawnRight")
            {
                VerticalDirection = false;
                Gravity = -Gravity;
                intialChange = true;
            }
            else if (col.tag == "SpawnUp")
            {
                VerticalDirection = true;
                Gravity = -Gravity;
                intialChange = true;
            }
            else if (col.tag == "SpawnDown")
            {
                VerticalDirection = true;
                intialChange = true;
            }
        }
    }

    void OffCamera()
    {
        if((transform.position.x < Camera.main.rect.xMin-15 || transform.position.x > Camera.main.rect.xMax+15) 
            || (transform.position.y < Camera.main.rect.yMin-10 || transform.position.y > Camera.main.rect.yMax+10))
        {
            //IsOffScreen = true;
            Destroy(this.gameObject);
        }
    }

}
