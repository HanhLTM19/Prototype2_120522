using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    GameController gameController;

    float spawnTime = 3;
    float m_spawnTime;

    float xRange = 20;
    float zPos = 30;

    float sideSpawnMinZ = -10;
    float sideSpawnMaxZ = 25;
    float sideSpawnX = 22;
    float spawnRotation = 90;
    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>(gameController);
        m_spawnTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;
        if (gameController.IsGameOver())
        {
            m_spawnTime = 0;
            return;
        }
        else if (m_spawnTime <= 0)
        {
            SpawnAnimal();
            SpawnLeftAnimal();
            SpawnRightAnimal();
            m_spawnTime = spawnTime;
        }
    }
    public void SpawnAnimal()
    {
        int animalIndex = Random.Range(0, animalsPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-xRange, xRange), 0, zPos);
        Instantiate(animalsPrefabs[animalIndex], spawnPosition,
                animalsPrefabs[animalIndex].transform.rotation);
    }
    public void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalsPrefabs.Length);
        Vector3 rotation = new Vector3(0, spawnRotation, 0);
        Vector3 spawnPosition = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Instantiate(animalsPrefabs[animalIndex], spawnPosition, Quaternion.Euler(rotation));
    }
    public void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalsPrefabs.Length);
        Vector3 rotation = new Vector3(0, -spawnRotation, 0);
        Vector3 spawnPosition = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Instantiate(animalsPrefabs[animalIndex], spawnPosition, Quaternion.Euler(rotation));

    }
}
