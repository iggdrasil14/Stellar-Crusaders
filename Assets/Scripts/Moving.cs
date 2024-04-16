using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public int pilotSpeed = 5; // �������� �������
    public float pilotShipAngle = 45.0f; // ���� ������� �������
    public float tiltSpeed = 2.0f; // �������� �������

    private Quaternion targetRotation; // ������� ��������

    private void Start()
    {
        // �������������� ������� �������� ������� ��������� �������
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
            targetRotation = Quaternion.Euler(0, 0, pilotShipAngle); // ������� ���� ������� �����
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * pilotSpeed * Time.deltaTime, Space.World);
            targetRotation = Quaternion.Euler(0, 0, -pilotShipAngle); // ������� ���� ������� ������
        }
        else
        {
            targetRotation = Quaternion.Euler(0, 0, 0); // ������� � ��������� ��������
        }

        // ������ �������� �������� ������� � ��������
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * tiltSpeed);
    }
}
