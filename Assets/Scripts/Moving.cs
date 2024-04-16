using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public int pilotSpeed = 5; // Скорость корабля
    public float pilotShipAngle = 45.0f; // Угол наклона корабля
    public float tiltSpeed = 2.0f; // Скорость наклона

    private Quaternion targetRotation; // Целевое вращение

    private void Start()
    {
        // Инициализируем целевое вращение текущим вращением объекта
        targetRotation = transform.rotation;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * pilotSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * pilotSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * pilotSpeed * Time.deltaTime, Space.World);
            targetRotation = Quaternion.Euler(0, 0, pilotShipAngle); // Целевой угол наклона влево
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * pilotSpeed * Time.deltaTime, Space.World);
            targetRotation = Quaternion.Euler(0, 0, -pilotShipAngle); // Целевой угол наклона вправо
        }
        else
        {
            targetRotation = Quaternion.Euler(0, 0, 0); // Возврат к исходному вращению
        }

        // Плавно изменяем вращение корабля к целевому
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * tiltSpeed);
    }
}
