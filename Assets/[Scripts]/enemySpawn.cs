// Adir
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public GameObject target;
    [SerializeField]
    private GameObject EnemyPrefab;
    [SerializeField]
    private float spawnRate = 10;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(spawnRate, EnemyPrefab));
    }

    // Update is called once per frame
    private IEnumerator spawnEnemy(float timeInterval, GameObject enemy)
    {

        yield return new WaitForSeconds(timeInterval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(target.transform.position.y + 10f, target.transform.position.y + 9), enemy.transform.position.z), Quaternion.identity);
        StartCoroutine(spawnEnemy(timeInterval, enemy));
    }
}