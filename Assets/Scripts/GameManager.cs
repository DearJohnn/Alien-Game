using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int maxHealth = 100;
    static int currentHealth;
    public static HealthBar healthBar;
    public static bool creditCard = false;
    public static int coin = 0;
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
        if(currentHealth <= 0)
        {
            Lose();
        }
    }
    public static void Damage()
    {
        currentHealth -= 25;

        healthBar.UpdateHealthBar(maxHealth, currentHealth);
    }

    public static void Win()
    {
        SceneManager.LoadScene("Gameover");
    }
    public static void Lose()
    {
        SceneManager.LoadScene("Gameover2");
    }
}
