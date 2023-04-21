using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] float _turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.up * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.position -= transform.up * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, _turnSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -_turnSpeed * Time.deltaTime, 0);
        }

    }
}
