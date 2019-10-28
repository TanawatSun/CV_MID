using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] Text textScore, healthText;
    [SerializeField] GameObject gameOverText;
    int score;
    
    private void Update()
    {
        textScore.text = score.ToString();
        healthText.text = health.ToString();
        if(health<=0)
        {
            gameOverText.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void Score(int addScore)
    {
        score += addScore;
        
    }

    public void DeHealth(int de_Health)
    {
        health -= de_Health;
    }

    
}
