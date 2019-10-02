using UnityEngine;

public class HoverPad : MonoBehaviour
{
    public float hoverForce = 12f;

    void OnTriggerEnter(Collider other)
    {
        other.attachedRigidbody.AddForce(Vector3.up * hoverForce, ForceMode.Acceleration);
    }
}