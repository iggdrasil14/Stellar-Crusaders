using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHP : MonoBehaviour
{
    public EnemyCounter enemyCounter;
    public float health = 50f; // Здоровье врага

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0f)
        {
            Die(); // Метод уничтожения врага
        }
    }

    void Die()
    {
        if (enemyCounter != null)
        {
            enemyCounter.EnemyDestroyed(); // Увеличиваем счетчик уничтоженных врагов
        }
        Destroy(gameObject);
    }
}
