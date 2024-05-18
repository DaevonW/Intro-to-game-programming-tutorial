using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Global Variables
    //In class CCNY MW
    // Start is called before the first frame update

    public Rigidbody2D playerBody;
    public float jumpForce = 300;

    public float playerSpeed = 0.05f;
    public bool isJumping = false;
    public float jumpSpeed = 300f; //final change
    private Rigidbody2D player; //final change

    //player health
    public int maxHealth = 20;
    public int currentHealth;
    public HealthBar healthBarScript;


    //"flip" direction variables
    public bool flippedLeft; //keeps track of which way our sprite is currently facing
    public bool facingRight; //keeps track of which way our sprite should be facing
    public bool facingLeft;

    //sound effect stuff
    public AudioSource lavaRockAudio;
    void Start()
    {
        currentHealth = maxHealth;
        healthBarScript.SetMaxHealth(maxHealth);
        player = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        Jump();

        if(Input.GetButtonDown("Jump")) //final change
        {
                player.velocity = new Vector2(player.velocity.x, jumpSpeed);//final change
        }
    }

    private void MovePlayer()
    {
        Vector3 newPos = transform.position;
        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("A pressed");
            newPos.x -= playerSpeed;
            facingLeft = true;
            Flip(facingLeft);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("D pressed");
            newPos.x += playerSpeed;
            facingLeft = false;
            Flip(facingLeft);
        }
        transform.position = newPos;
    }
    private void Jump()
    {
        if(!isJumping && Input.GetKeyDown(KeyCode.Space))
        {
            playerBody.AddForce(new Vector3(playerBody.velocity.x, jumpForce, 0));
            isJumping = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Surface")
        {
            isJumping = false;
        }
        
        if(collision.gameObject.tag == "Lava")
        {
            TakeDamage(2);

            lavaRockAudio.Play();
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBarScript.SetHealth(currentHealth);
    }
    void Flip(bool facingLeft)
    {
        //Debug.Log("Flip() called. facingRight = " + facingRight);
        if (facingLeft && !flippedLeft)
        {
            transform.Rotate(0, -180, 0);
            flippedLeft = true;
        }
        if (!facingLeft && flippedLeft)
        {
            transform.Rotate(0, -180, 0);
            flippedLeft = false;
        }
    }
    
}
