using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBounds = -10f;
    private float lowBounds = -3.5f;
    private float rightBounds = 35;

    private void Awake()
    {
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        AnimalDestroy();
    }
    private void AnimalDestroy()
    {
        if (transform.position.z <= lowBounds)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
        else if (transform.position.x >= rightBounds || transform.position.x <= -rightBounds)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pizza")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Game OVERRRS");
            Destroy(gameObject);
        }

    }
 
}
