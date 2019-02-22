using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Gravity = 5.8f;
    public bool VerticalDirection = true;

   
    public bool IsOffScreen = true;

    
    
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
        }
        if (!VerticalDirection)
        {
            rbApple.velocity = new Vector2(Gravity, 0);
        }

        OffCamera();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="SpawnLeft")
        {
            VerticalDirection = false;
            
        }
        else if(col.tag=="SpawnRight")
        {
            VerticalDirection = false;
            Gravity = -Gravity;
        }
        else if (col.tag == "SpawnUp")
        {
            VerticalDirection = true;
            Gravity = -Gravity;
        }
        else if (col.tag == "SpawnDown")
        {
            VerticalDirection = true;
        }

    }

    void OffCamera()
    {
        if(transform.position.x<Camera.main.rect.xMin-10 || transform.position.x > Camera.main.rect.xMax+10 || transform.position.y < Camera.main.rect.yMin - 10 || transform.position.y > Camera.main.rect.yMax + 10)
        {
            IsOffScreen = true;
        }
    }

}
