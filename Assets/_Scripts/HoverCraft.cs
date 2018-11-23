using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverCraft : MonoBehaviour
{
    public float speed = 90f;
    public float strafeSpeed = 5f;
    public float hoverForce = 65f;
    public float hoverHeight = 3.5f;
    [SerializeField]
    private float powerInput;
    [SerializeField]
    private float strafeInput;
    private Rigidbody hoverRgbd;


    void Awake () 
    {
        hoverRgbd = GetComponent <Rigidbody>();
    }

    void Update () 
    {
        powerInput = Input.GetAxis ("Vertical");
        strafeInput = Input.GetAxis ("Horizontal");
    }

    void FixedUpdate()
    {
        Ray ray = new Ray (transform.position, -transform.up);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, hoverHeight))
        {
            float proportionalHeight = (hoverHeight - hit.distance) / hoverHeight;
            Vector3 appliedHoverForce = Vector3.up * proportionalHeight * hoverForce;
            hoverRgbd.AddForce(appliedHoverForce, ForceMode.Acceleration);
        }

        hoverRgbd.AddRelativeForce(0f, 0f, powerInput * speed);
        hoverRgbd.AddRelativeForce(strafeInput * strafeSpeed, 0f, 0f);

    }
}
