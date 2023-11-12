using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class player : MonoBehaviour //sets health for player, takes damage for player, need to separate for player and enemies
{
    public int maxHealth;
    public int currentHealth;

   // public healthbar HP; //traditional slider
    public HealthSprites health; //sprites
    public void Start()
    {
        maxHealth = 6;
        currentHealth = maxHealth;

        health.health = maxHealth; //sprites
        health.numOfHearts = maxHealth;

      //  HP.SetMaxHealth(maxHealth); //traditional slide
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

      //  HP.SetHealth(currentHealth); //traditional slider
        health.health = currentHealth; //sprites
    }
}
