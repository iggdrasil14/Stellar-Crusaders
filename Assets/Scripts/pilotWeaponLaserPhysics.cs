using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pilotWeaponLaserPhysics : MonoBehaviour
{
    public float damage = 2f; // Урон, который наносит лазер

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy")) // Проверяем, является ли объект врагом
        {
            enemyHP enemy = other.GetComponent<enemyHP>(); // Получаем компонент Enemy
            if (enemy != null)
            {
                enemy.TakeDamage(damage); // Наносим урон
            }
            Destroy(gameObject); // Уничтожаем лазер после попадания
        }
    }
}
