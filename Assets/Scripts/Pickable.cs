using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    public int scoreAmount = 2;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Pizza")
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            scoreManager.score += scoreAmount;
        }
        else if (other.gameObject.tag == "Player")
        {
            HealthManager healthManager = FindObjectOfType<HealthManager>();
            healthManager.health--;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            scoreManager.score += scoreAmount;

            Destroy(gameObject);
        }
    }
}
