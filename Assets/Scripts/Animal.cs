using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    GameController gameController;
    // Start is called before the first frame updat
    void Start()
    {
        gameController = FindObjectOfType<GameController>(gameController);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pizza"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Player"))
        {
            gameController.SetIsGameOver(true);
            Destroy(other.gameObject);
        }
    }
}
