using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pilotWeaponLaserPhysics : MonoBehaviour
{
    public float damage = 2f; // ����, ������� ������� �����

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy")) // ���������, �������� �� ������ ������
        {
            enemyHP enemy = other.GetComponent<enemyHP>(); // �������� ��������� Enemy
            if (enemy != null)
            {
                enemy.TakeDamage(damage); // ������� ����
            }
            Destroy(gameObject); // ���������� ����� ����� ���������
        }
        if (other.CompareTag("Enemy")) // ���������, �������� �� ������ ������
        {
            BossHP bossHP = other.GetComponent<BossHP>(); // �������� ��������� Enemy
            if (bossHP != null)
            {
                bossHP.TakeDamage(damage); // ������� ����
            }
            Destroy(gameObject); // ���������� ����� ����� ���������
        }
    }
}
