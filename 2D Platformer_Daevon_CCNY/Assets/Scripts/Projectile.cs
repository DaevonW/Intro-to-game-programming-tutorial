using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    //global variables
    public Rigidbody2D projectileRb;
    public float speed = 5;
    //projectile countdown timer stuff
    public float projectileLife = 2;
    public float projectileCount;
    //flip direction
    public bool facingLeft;
    public PlayerController playerControllerScript;

    void Start()
    {
        projectileCount = projectileLife;

        playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

        facingLeft = playerControllerScript.facingLeft;

        if (!facingLeft)
        {
            transform.rotation = Quaternion.Euler(0, 100, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        projectileCount -= Time.deltaTime;
        if (projectileCount <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {

    if (facingLeft)
    {
            projectileRb.velocity = new Vector3(speed, projectileRb.velocity.y,0);

    }
    else //if facing right move the other direction
    {
                projectileRb.velocity = new Vector3(-speed, projectileRb.velocity.y,0);
    }

    }
       
    
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            //Debug.Log("projectile hit lava");
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }
}
