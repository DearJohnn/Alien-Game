using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image healthbarsprite;

    public void UpdateHealthBar(float maxHealth, float currentHealth)
    {
        healthbarsprite.fillAmount = currentHealth / maxHealth;
    }
}
