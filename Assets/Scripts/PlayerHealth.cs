using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;
    public static bool gameOver;
    public GameObject gameOverPanel;


    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <=0)
        {
           // SceneManager.LoadScene("GameOver");
           gameOverPanel.SetActive(true);
           //GameOverScreen.Setup(maxPlatform);
           Time.timeScale = 0;
           
        }
        
    }
}
