using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwards : MonoBehaviour
{
    [SerializeField] private float m_Speed = 40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * m_Speed * Time.deltaTime);
    }
}
