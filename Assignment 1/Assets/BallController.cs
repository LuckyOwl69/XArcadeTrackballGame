using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float ballSpeed = 300;

    void Update()
    {
        float xAxisSpeed = Input.GetAxis("Mouse X");
        float yAxisSpeed = Input.GetAxis("Mouse Y");

        Rigidbody body = GetComponent<Rigidbody>();
        body.AddTorque(new Vector3(xAxisSpeed, 0, yAxisSpeed) * ballSpeed * Time.deltaTime);
    }
}
