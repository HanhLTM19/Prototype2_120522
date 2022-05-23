using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour
{
    GameController gameController;
    public int pointValue;

    public Slider m_slider;
    public int maxFedAmount;

    private int currentFedAmount = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>(gameController);
        m_slider.maxValue = maxFedAmount;
        //m_slider.value = 0;
        m_slider.fillRect.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void FeedAnimal(int amount)
    {
        currentFedAmount += amount;
        m_slider.fillRect.gameObject.SetActive(true);
        m_slider.value = currentFedAmount;
        if (currentFedAmount >= maxFedAmount)
        {
            gameController.UpdateScore(pointValue);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pizza"))
        {
            FeedAnimal(1);
            /*gameController.UpdateScore(pointValue);
            Destroy(gameObject);
            Destroy(other.gameObject);*/

        }
        if (other.gameObject.CompareTag("Player"))
        {
            gameController.UpdateLives();

        }
    }
}
