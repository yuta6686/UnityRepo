using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{

    [SerializeField]  float rotSpeedClick = 10.0f;
    float rotSpeed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = rotSpeedClick;
        }

        transform.Rotate(0, 0, this.rotSpeed);

        this.rotSpeed *= 0.96f;
    }
}
