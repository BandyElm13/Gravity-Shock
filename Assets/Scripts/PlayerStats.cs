using System;
using System.Collections;
using System.Threading;
using NUnit.Framework.Internal;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]
        private float maxHealth = 100f;
        private float currentHealth;

        [SerializeField]
        private Slider healthBar;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
    }

    public void takeDamage(float amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        healthBar.value = currentHealth;
    }
    public void regenHealth()
    {
        StartCoroutine(RegenCoroutine());
    }

    private IEnumerator RegenCoroutine()
    {
        while (currentHealth <= 75f)
        {
            yield return new WaitForSeconds(20f);
            currentHealth += 1;
            currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
            healthBar.value = currentHealth;
        }
    }


    public void testDamage()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            currentHealth -= 10;
            healthBar.value = currentHealth;
        }
    }

    void Update()
    {
        regenHealth();
        testDamage();
    }

}
