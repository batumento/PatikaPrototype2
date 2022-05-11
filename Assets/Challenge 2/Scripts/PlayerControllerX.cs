using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float pressCheck;

    // Update is called once per frame
    void Update()
    {
        pressCheck += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && pressCheck >= 1f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            pressCheck = 0f;
        }
    }
}
