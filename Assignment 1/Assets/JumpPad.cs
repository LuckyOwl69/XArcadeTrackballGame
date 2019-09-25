using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public int speed;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * speed);
        }
    }
}