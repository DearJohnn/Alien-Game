using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int maxHealth = 100;
    static int currentHealth;
    public static HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.UpdateHealthBar(maxHealth, currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.UpdateHealthBar(maxHealth, currentHealth);
    }
    public static void Damage()
    {
        currentHealth -= 10;

        healthBar.UpdateHealthBar(maxHealth, currentHealth);
    }
}
