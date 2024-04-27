using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pilotWeaponLaserDamage : MonoBehaviour
{
    public GameObject pilotWeaponLaser; // Префаб лазера
    public Transform firePoint; // Точка, откуда будет вылетать лазер
    public float laserSpeed = 50f; // Скорость лазера

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Проверка нажатия левой кнопки мыши
        {
            ShootLaser();
        }
    }

    public void ShootLaser()
    {
        GameObject laser = Instantiate(pilotWeaponLaser, firePoint.position, firePoint.rotation);   
        Rigidbody rb = laser.GetComponent<Rigidbody>();
        rb.velocity = firePoint.forward * laserSpeed; // Дает лазеру скорость в направлении firePoint
    }
}
