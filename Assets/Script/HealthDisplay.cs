using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;    //Give this script access to UI functions.

public class HealthDisplay : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public Sprite emptyHeart;
    public Sprite fullHeart;           //Create a box in Unity to store our empty and full heart sprites
    public Image[] hearts;

    public PlHealth playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        health = playerHealth.health;
        maxHealth = playerHealth.maxHealth;

        for (int i = 0; i < hearts.Length; i++)         //Hearts.Length creates an intteger equal to however 
        {                                               //many hearts you put in your list in Unity.
            if(i<health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            
            if(i < maxHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
