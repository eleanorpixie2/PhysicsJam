using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Gravity = 9.8f;
    public bool VerticalDirection = true;

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
    }
}
