using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float spawnTime;
    float m_spawnTime;

    bool m_isGameOver;
    public GameObject[] animalsPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        m_spawnTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;
        if (m_isGameOver)
        {
            m_spawnTime = 0;
            return;
        }
        if (m_spawnTime <= 0)
        {
            SpawnAnimal();
            m_spawnTime = spawnTime;
        }
    }
    public void SpawnAnimal()
    {
        int animalIndex = Random.Range(0, animalsPrefabs.Length);
        Vector3 spawnPosition = new Vector3 (Random.Range(-20, 25), 0, 30);
        Instantiate(animalsPrefabs[animalIndex], spawnPosition,
                animalsPrefabs[animalIndex].transform.rotation);
    }


    public void SetIsGameOver(bool state)
    {
        m_isGameOver = state;
    }
    public bool IsGameOver()
    {
        return m_isGameOver;
    }
}
