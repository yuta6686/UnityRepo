using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController_Rep : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 0.0f;

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            speed = 20.0f;
        }

        transform.Rotate(0.0f, 0.0f, speed);
        speed *= 0.99f;


    }
}
