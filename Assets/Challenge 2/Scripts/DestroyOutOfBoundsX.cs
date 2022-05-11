using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        DestroyDog();
        DestroyBall();
    }
    private void DestroyDog()
    {
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
    }
    private void DestroyBall()
    {
        if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
    }
}
