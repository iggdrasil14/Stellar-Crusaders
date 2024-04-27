using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pilotWeaponLaserDamage : MonoBehaviour
{
    public GameObject pilotWeaponLaser; // ������ ������
    public Transform firePoint; // �����, ������ ����� �������� �����
    public float laserSpeed = 50f; // �������� ������

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // �������� ������� ����� ������ ����
        {
            ShootLaser();
        }
    }

    public void ShootLaser()
    {
        GameObject laser = Instantiate(pilotWeaponLaser, firePoint.position, firePoint.rotation);   
        Rigidbody rb = laser.GetComponent<Rigidbody>();
        rb.velocity = firePoint.forward * laserSpeed; // ���� ������ �������� � ����������� firePoint
    }
}
