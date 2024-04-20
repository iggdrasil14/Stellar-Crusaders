using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject asteroidPrefab;
    // Start is called before the first frame update
    private void Start()
    {
        //����� ���������� ������� InvokeRepeating ��� ������ ������ EnemyRandomGenerator
        //����� ������ 5 ������, ������� � 5-��������� �������� ����� �������.
        InvokeRepeating(nameof(EnemyRandomGenerator), 5, 5);
    }

    public Vector3 GetRandomPoint()
    {
        Vector3 point = Vector3.zero;
        point = Random.insideUnitSphere * 15;
        point.y = transform.position.y;
        return point;
    }

    void EnemyRandomGenerator()
    {
        // ��� ������
        GameObject Asteroid = Instantiate(asteroidPrefab, GetRandomPoint(), Quaternion.identity);
        //Moving_enemy_skeleton x = Skeleton.GetComponent<Moving_enemy_skeleton>();
        //x.point = transform;
    }
}
