using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    //Global Variables
    public Rigidbody2D rbBall;

    public float force = 200;

    private float xDir;
    private float yDir;

    public bool inPlay;
    public Vector3 ballStartPos;

    void Start()
    {
        Launch();

    }

    void update()
    {
    
        
        if (inPlay == false)
        {
            transform.position = ballStartPos;
            Launch();
        }
    }


    void Launch()
    {
        Vector3 direction = new Vector3(0, 0, 0);

        xDir = Random.Range(0, 2);
        if(xDir==0){
            //Debug.Log("xDir ="  + xDir);
            direction.x = -1;
        }
        if (xDir == 1)
        {
            direction.x = 1; 
        }

        yDir = Random.Range(0, 2);
        if (yDir == 0)
        {
            //Debug.Log("yDir ="  + yDir);
            direction.y = -1;
        }
        if (yDir == 1)
        {
            direction.y = 1;
        }
        //add force to start movement'
        rbBall.AddForce(direction * force);
        inPlay = true;

    }

    //Events Upon Collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("object that collided w/Ball:" + collision.gameObject.name);
        //Debug.Log(" object that collided w/Ball: " + collision.gameObject.name);
        if (collision.gameObject.name == "Left Wall")
        {
            Debug.Log("collided with Left Wall");
        }
    }
}




