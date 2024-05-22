using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image healthBar;
    void Start()
    {
        maxHealth = health; //Start game with max health 
    }

    void update()
    {
      healthBar.fillAmount = Mathf.Clamp(health/maxHealth,0,1);//resticting the health amount
    }
   
}
