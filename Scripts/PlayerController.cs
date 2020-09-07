using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;

    float xInput;

    Vector2 newPosition;

    public float moveSpeed;

    public float xPositionLimit;

    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update

    
    void Update()
    {
        float xPosition = transform.position.x;
        if (xPosition < -xPositionLimit)
        {
            StopMoving();
        }

        if (xPosition > xPositionLimit)
        {
            StopMoving();
        }


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touch_Pos = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch_Pos.x < 0 && touch_Pos.y < 3)
            {                   
                if (xPosition > - xPositionLimit) { 
                    MoveLeft();
                }
            }
            else if (touch_Pos.x > 0 && touch_Pos.y < 3)
            {
                if (xPosition < xPositionLimit ) { 
                    MoveRight();
                }
            }
        }
        else
        {
            StopMoving();
        }
        
    }

    private void MoveLeft()
    {
        rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
    }

    private void MoveRight()
    {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }

    private void StopMoving()
    {
        rb.velocity = new Vector2(0f, rb.velocity.y);
    }
    

}

