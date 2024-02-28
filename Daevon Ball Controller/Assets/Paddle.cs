
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle: MonoBehaviour
{
    //mw  in class
    //Global Variables
    public Rigidbody2D rbPaddle;
    public bool isPlayer1;
    public float paddleSpeed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Paddle Script");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            Player1Control();
        }
        else
        {
            Player2Control();
        }
        
    }
    void Player1Control()
    {
        //Debug.Log("is player 1");
        Vector3 newPos = transform.position;
        if (newPos.y <= 4.1f && newPos.y >= -4.1f)

        // PLAYER MOVEMENT CONTROLS
        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log("W key pressed");
            newPos.y += paddleSpeed;

        }else if (Input.GetKey(KeyCode.S))
        {
            //Debug.Log("S key pressed");
            newPos.y -= paddleSpeed;
        }
        transform.position = newPos;
    }

    if (newPos.y >= 4.1f)
        {

        }
        else if (newPos.y <=-4.1f)
        {
        newPos.y = -4;
        transform.position = new pos;

        }
    void Player2Control()
    {
        //Debug.Log("is player2");
    }

