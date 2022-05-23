using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int m_score = 0;
    public int m_lives = 3;
    bool m_isGameOver;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsGameOver())
        {
            return;
        }    
    }
    public void UpdateScore(int score)
    {
        m_score += score;
    }
    public void UpdateLives()
    {
        if (m_lives > 1)
        {
            m_lives = m_lives - 1;
            
        }
        else
        {
            m_lives = 0;
            SetIsGameOver(true);
        }
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
