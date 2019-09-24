using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Ball;
    public float xOffset = 0, yOffset = 5, zOffset = -5;

    void Update()
    {
        transform.position = Ball.transform.position + new Vector3(xOffset, yOffset, zOffset);
        transform.LookAt(Ball.transform.position);
    }
}
