using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerHealth plHealth;
    public float damage; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player")) //if the player collisides with obstacle health is damaged
        {
            plHealth.health -= damage; 
        }
    }

}
