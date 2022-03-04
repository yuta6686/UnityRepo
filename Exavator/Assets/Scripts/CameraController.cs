using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject mainCamera;
    private GameObject player;
    public float rotateSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main.gameObject;
        player = GameObject.Find("excavetor");
    }

    // Update is called once per frame
    void Update()
    {
        RotateCamera();
    }

    private void RotateCamera()
    {
        Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * rotateSpeed,
            Input.GetAxis("Mouse Y") * rotateSpeed, 0);

        mainCamera.transform.RotateAround(player.transform.position, Vector3.up, angle.x);
        mainCamera.transform.RotateAround(player.transform.position, transform.right, angle.y);
    }
}
