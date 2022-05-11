using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;
    [SerializeField] private GameObject[] angryAnimalPrefabs;
    private float spawnRange = 20f;
    private float[] spawnSideRangeX = { 31, -31 };
    private float spawnSideRangeZMin = -1f;
    private float spawnSideRangeZMax = 5f;
    private float spawnPosZ = 20f;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRangeAnimal", startDelay, spawnInterval);//Mükemmel bir metod
        InvokeRepeating("SpawnRangeAngryAnimals", 5, 5);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void SpawnRangeAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    private void SpawnRangeAngryAnimals()
    {
        int rangePosX = Random.Range(0, spawnSideRangeX.Length);
        int animalIndex = Random.Range(0, angryAnimalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnSideRangeX[rangePosX], 0, Random.Range(spawnSideRangeZMin, spawnSideRangeZMax));
        if (rangePosX == 0)
        {
            Instantiate(angryAnimalPrefabs[animalIndex], spawnPos, Quaternion.LookRotation(Vector3.left));
        }
        else
        {
            Instantiate(angryAnimalPrefabs[animalIndex], spawnPos, Quaternion.LookRotation(Vector3.right));
        }
    }
    public void SpawnGame()
    {
        SceneManager.LoadScene(0);
    }
}
