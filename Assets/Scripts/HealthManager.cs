using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private Text maxHealth;
    public int health = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealth();
        Die();
    }
    private void UpdateHealth()
    {
        maxHealth.text = "Health: " + health.ToString();
    }
    private void Die()
    {
        if (health <= 0 )
        {
            gameOverPanel.SetActive(true);
        }
    }

}
