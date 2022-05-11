using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float xRange = 18.0f;
    private float zRange = 5f;
    private float zBound = -1f;
    [SerializeField] private float playerSpeed;
    [SerializeField] private GameObject projectilePrefabs;
    void Update()
    {
        RangeBounds();
        PlayerMove();
        PizzaSpawn();
    }
    private void PlayerMove()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * playerSpeed * Time.deltaTime);

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * playerSpeed * Time.deltaTime);
    }
    private void PizzaSpawn()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefabs, transform.position, projectilePrefabs.transform.rotation);
        }

    }
    private void RangeBounds()
    {

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        else if (transform.position.z < zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
    }
}
