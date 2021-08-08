using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed = 25.0f;
    public float horizontalInput;
    public float verticalInput;

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode swichKey;

    public string inputID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get input from player
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        verticalInput = Input.GetAxis("Vertical" + inputID);

        //Move the vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * turnSpeed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        //Switch the Camera
        if (Input.GetKeyDown(swichKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }


    }
}
