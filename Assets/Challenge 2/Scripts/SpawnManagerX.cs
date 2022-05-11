using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnIntervalMin = 2.0f;
    private float spawnIntervalMax = 5.0f;
    private float passedTime = 0.0f;
    private float nextTime;

    // Start is called before the first frame update
    void Start()
    {
        nextTime = startDelay;
    }
    private void Update()
    {
        passedTime += Time.deltaTime;
        if (passedTime > nextTime)
        {
            SpawnRandomBall();
            nextTime = Random.Range(spawnIntervalMin, spawnIntervalMax);
            passedTime = 0.0f;
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        int spawnPrefabs = Random.Range(0, ballPrefabs.Length);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[spawnPrefabs], spawnPos, ballPrefabs[spawnPrefabs].transform.rotation);
    }
}
