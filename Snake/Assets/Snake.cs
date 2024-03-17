using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Snake : MonoBehaviour
{
    //VOLLEGR NOW IN CLASS MW
    //GLOBAL VARIABLES
    Vector3 dir = Vector3.right;


    //Keep Track of Tail Elements
    List<Transform> tail = new List<Transform>();
    bool ate = false;
    public GameObject tailPrefab;

    public GameManager myManager;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MoveSnake", 0.1f, 0.1f); //Changed the speed of the ssnake
    }

    // Update is called once per frame
    void Update()
    {
        ChangeDirection();
    }
    void MoveSnake()
    {
        Vector3 gap = transform.position;
        transform.Translate(dir); 

        if (ate)
        {
            Debug.Log("ate =" + ate);
            GameObject tailSec = (GameObject)Instantiate(tailPrefab, gap, Quaternion.identity);
                tail.Insert(0, tailSec.transform);

            ate = false;
        }

        //check if snake has a tail
        if (tail.Count > 0)
        {
            //move the last Tail to where the Head previously was
            tail.Last().position = gap;

            //Keep our Tail list in order!
            //Add Last Tail element to the front of the list and remove from the back 
            tail.Insert(0, tail.Last());
            tail.RemoveAt(tail.Count - 1);
        }
    }
    private void ChangeDirection()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dir = Vector3.left;
        }
        else if ((Input.GetKey(KeyCode.DownArrow)))
        {
            dir = Vector3.down;
         
        }
        else if ((Input.GetKey(KeyCode.UpArrow)))
            {
            dir = Vector3.up;
        }
        else if ((Input.GetKey(KeyCode.RightArrow)))
        {
            dir = Vector3.right;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            ate = true;

            //Debug.Log("food eaten");
            Destroy(collision.gameObject); //Remove the Food
            //change score
            myManager.FoodEaten();
        }
        else if (collision.gameObject.name == "Right Wall")
        {
            dir = Vector3.left;
        }
        else if (collision.gameObject.name == "Left Wall")
        {
            dir = Vector3.right;
        }
        else if (collision.gameObject.name == "Bottom Wall")
        {
            dir = Vector3.up;
        }
        else if (collision.gameObject.name == "Top Wall")
        {
            dir = Vector3.down;
        }
    }
}
