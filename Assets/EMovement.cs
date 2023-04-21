using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMovement : MonoBehaviour
{
    public float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            transform.position += transform.right * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.position -= transform.right * _speed * Time.deltaTime;
        }
    }
}
