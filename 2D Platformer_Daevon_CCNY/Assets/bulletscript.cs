using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{
     public float speed;
     Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        rb.velocity = transform.right* speed; //detect the speed of the bullet 


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
