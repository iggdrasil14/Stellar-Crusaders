using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public EnemyCounter eCounter;
    public Transform point1, point2;
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
        point.x = Random.Range(point1.position.x, point2.position.x);
        point.y = point1.position.y;
        point.z = point1.position.z;
        return point;
    }

    void EnemyRandomGenerator()
    {
        // ��� ������
        GameObject Asteroid = Instantiate(asteroidPrefab, GetRandomPoint(), Quaternion.identity);
        Asteroid.GetComponent<enemyHP>().enemyCounter = eCounter;
        //Moving_enemy_skeleton x = Skeleton.GetComponent<Moving_enemy_skeleton>();
        //x.point = transform;
    }
}
