using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCam : MonoBehaviour
{
public float HorizontalPanSpeed = 5f; //rotation speed 

public float VerticalPanSpeed = 5f; //pitch up down speed

public float minimumX = -360f;
public float maximumX = 360f;

public float minimumY = -76f;
public float maximumY = -76f;

private Rigidbody selfBody;

private Transform cameraTransform;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
