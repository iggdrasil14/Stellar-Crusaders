using System.Collections;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public EnemyCounter eCounter;
    public Transform point1, point2;

    private void Start()
    {
        StartCoroutine(EnemyCoroutine());
    }

    private IEnumerator EnemyCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            float health = Mathf.Round(Random.Range(1f, 10f));
            float scale = GetScaleFromHealth(health);
            EnemyRandomGenerator(scale, health);
        }
    }

    private float GetScaleFromHealth(float health)
    {
        if (health <= 3)
        {
            return 0.25f;
        }
        else if (health > 3 && health <= 6)
        {
            return 0.5f;
        }
        else if (health > 6 && health < 10)
        {
            return 0.75f;
        }
        else // if (health == 10)
        {
            return 1f;
        }
    }

    private void EnemyRandomGenerator(float scale, float health)
    {

        if (eCounter.IsBossTime())
        {
            CreateBoss();
        }
        else
        {
            GameObject Asteroid = Instantiate(asteroidPrefab, GetRandomPoint(), Quaternion.identity);
            Asteroid.transform.localScale = asteroidPrefab.transform.localScale * scale;

            enemyHP x = Asteroid.GetComponent<enemyHP>();
            x.enemyCounter = eCounter;
            x.health = health;
        }
    }

    private void CreateBoss()
    {

    }

    public Vector3 GetRandomPoint()
    {
        Vector3 point = Vector3.zero;
        point.x = Random.Range(point1.position.x, point2.position.x);
        point.y = point1.position.y;
        point.z = point1.position.z;
        return point;
    }
}