using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    [SerializeField] Material lavaSlow;
    [SerializeField] Material lavaFast;
    bool isLavaFast = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            if (isLavaFast)
            {
                gameObject.GetComponent<MeshRenderer>().material = lavaSlow;
                isLavaFast = false;
            }
            else
            {
                gameObject.GetComponent<MeshRenderer>().material = lavaFast;
                isLavaFast = true;
            }
        }
    }
}
