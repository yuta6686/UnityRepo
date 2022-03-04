using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExcavetorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.TransformDirection(0.0f,-1.0f,0.0f) * 10.0f * Time.deltaTime;
        }
    }
}
