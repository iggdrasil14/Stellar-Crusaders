using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BossHP : MonoBehaviour
{
    public float bossHealth;

    public void Start()
    {
        bossHealth = 2f;
    }

    public void TakeDamage(float damage)
    {
        bossHealth -= damage;
        if (bossHealth <= 0f)
        {
            
            Die(); // Метод уничтожения босса
           
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
