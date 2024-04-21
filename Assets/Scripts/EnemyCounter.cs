using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyCounter : MonoBehaviour
{
    public TextMeshProUGUI enemyCountText; // Ссылка на UI элемент Text для отображения количества уничтоженных врагов
    private int destroyedEnemyCount = 0; // Счетчик уничтоженных врагов

    void Start()
    {
        UpdateEnemyCountDisplay(); // Обновляем дисплей при старте
    }
    public bool IsBossTime()
    {
        return destroyedEnemyCount % 3 == 0;
    }

    public void EnemyDestroyed() // Метод для вызова при уничтожении врага
    {
        destroyedEnemyCount++; // Увеличиваем счетчик уничтоженных врагов
        UpdateEnemyCountDisplay(); // Обновляем текст
    }

    void UpdateEnemyCountDisplay() // Метод обновления текста на дисплее
    {
        if (enemyCountText != null)
        {
            enemyCountText.text = "Score: " + destroyedEnemyCount; // Устанавливаем текст счетчика
        }    
                    
        else
            Debug.LogError("Enemy count Text component is not assigned!"); // Выводим ошибку, если компонент текста не назначен
    }
}
