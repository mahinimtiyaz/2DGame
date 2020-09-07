using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject obstacle;

    public float xPositionLimit;

    public float spawnRate;

    public float upspeed;
    
    // Start is called before the first frame update
    void Start()
    {
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * upspeed);
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-xPositionLimit, xPositionLimit);

        Vector2 spawnPosition = new Vector2(randomX, transform.position.y);

        Instantiate(obstacle, spawnPosition, Quaternion.identity);

    }

    void StartSpawning()
    {
        InvokeRepeating("SpawnEnemy", 1f, spawnRate);
    }

    public void StopSpawning()
    {
        CancelInvoke("SpawnEnemy");
    }
}
