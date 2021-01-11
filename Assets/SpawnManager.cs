using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject catcherPrefab;

    public Vector2 spawnRangeX;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 0, 2.0f);
        InvokeRepeating(nameof(SpawnCatcher), 1.0f, 2.0f);
    }

    private void SpawnCatcher()
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(spawnRangeX[0], spawnRangeX[1]),
            catcherPrefab.transform.position.y,
            catcherPrefab.transform.position.z);

        Instantiate(
            catcherPrefab,
            spawnPosition,
            catcherPrefab.transform.rotation);
    }

    private void SpawnEnemy()
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(spawnRangeX[0], spawnRangeX[1]),
            enemyPrefab.transform.position.y,
            enemyPrefab.transform.position.z);

        Instantiate(
            enemyPrefab,
            spawnPosition,
            enemyPrefab.transform.rotation);
    }
}
