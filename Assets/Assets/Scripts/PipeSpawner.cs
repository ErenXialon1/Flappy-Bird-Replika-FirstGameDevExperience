using System.Collections;
using System.Collections.Generic;

using System.Collections;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePairPrefab;
    public float spawnInterval = 2f;
    public float spawnDistance = 10f;
    public float minY = -1f;
    public float maxY = 3f;

    void Start()
    {
        StartCoroutine(SpawnPipePairs());
    }

    IEnumerator SpawnPipePairs()
    {
        while (true)
        {
            SpawnPipePair();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnPipePair()
    {
        float randomY = Random.Range(minY, maxY);
        Vector2 spawnPosition = new Vector2(transform.position.x + spawnDistance, randomY);
        GameObject newPipePair = Instantiate(pipePairPrefab, spawnPosition, Quaternion.identity);
        newPipePair.transform.SetParent(transform);
    }
}
