using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 6;

    public SpriteRenderer playerSr;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
            Destroy(gameObject);    //If the damage take the player down to zero, then player will be destroyed
        }
    }
}
