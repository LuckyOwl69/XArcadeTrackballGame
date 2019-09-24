using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float ballSpeed;

    public float jumpForce;

    private Rigidbody body;

    public LayerMask groundLayers;

    public LayerMask allLayers;

    public SphereCollider sphereCollider;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        sphereCollider = GetComponent<SphereCollider>();
    }

    void Update()
    {
        //locks cursor to the game window
        Cursor.lockState = CursorLockMode.Locked;
        
        //receiving mouse inputs
        float xAxisSpeed = Input.GetAxis("Mouse X");
        float yAxisSpeed = Input.GetAxis("Mouse Y");
        
        //moving using the mouse
        Vector3 movement = new Vector3(xAxisSpeed, 0, yAxisSpeed);

        //applying force on the ball in a direction
        body.AddForce(movement * ballSpeed);


        //jump function, right mouse button
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            body.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        
        ////jump function with ground check
        //if (IsGrounded() && Input.GetKeyDown(KeyCode.Mouse1))
        //{
        //    body.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        //}


        //slam function, left mouse button
        if (IsNotGrounded() && Input.GetKeyDown(KeyCode.Mouse0))
        {
            body.AddForce(Vector3.down * 10*jumpForce, ForceMode.Impulse);
        }

        ////slam function with ground check
        //if (IsNotGrounded() && Input.GetKeyDown(KeyCode.Mouse0))
        //{
        //    body.AddForce(Vector3.down * 10*jumpForce, ForceMode.Impulse);
        //}

        //move fast function, middle mouse button
        if (Input.GetKey(KeyCode.Mouse2))
        {
            body.AddForce(movement * (ballSpeed+100));
        }
    }

    //check to see if player is on the ground
    private bool IsGrounded()
    {
        return Physics.CheckCapsule(sphereCollider.bounds.center, 
            new Vector3(sphereCollider.bounds.center.x, sphereCollider.bounds.center.y, sphereCollider.bounds.center.z), 
            sphereCollider.radius * .9f, groundLayers);
    }

    //check to see if player is in the air
    private bool IsNotGrounded()
    {
        return Physics.CheckCapsule(sphereCollider.bounds.center,
            new Vector3(sphereCollider.bounds.center.x, sphereCollider.bounds.center.y, sphereCollider.bounds.center.z),
            sphereCollider.radius * .9f, allLayers);
    }
}
