using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyCounter : MonoBehaviour
{
    public TextMeshProUGUI enemyCountText; // ������ �� UI ������� Text ��� ����������� ���������� ������������ ������
    private int destroyedEnemyCount = 0; // ������� ������������ ������

    void Start()
    {
        UpdateEnemyCountDisplay(); // ��������� ������� ��� ������
    }
    public bool IsBossTime()
    {
        return destroyedEnemyCount % 3 == 0;
    }

    public void EnemyDestroyed() // ����� ��� ������ ��� ����������� �����
    {
        destroyedEnemyCount++; // ����������� ������� ������������ ������
        UpdateEnemyCountDisplay(); // ��������� �����
    }

    void UpdateEnemyCountDisplay() // ����� ���������� ������ �� �������
    {
        if (enemyCountText != null)
        {
            enemyCountText.text = "Score: " + destroyedEnemyCount; // ������������� ����� ��������
        }    
                    
        else
            Debug.LogError("Enemy count Text component is not assigned!"); // ������� ������, ���� ��������� ������ �� ��������
    }
}
