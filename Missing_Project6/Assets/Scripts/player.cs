using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class player : MonoBehaviour //sets health for player, takes damage for player, need to separate for player and enemies
{
    public int maxHealth = 10;
    public int currentHealth;

    public healthbar HP;
    public void Start()
    {
        currentHealth = maxHealth;
        HP.SetMaxHealth(maxHealth);

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        HP.SetHealth(currentHealth);
    }
}
