using UnityEngine;

public class CaptureKey : MonoBehaviour
{
    [SerializeField] private GameObject key;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == ("Key"))
        {
            Destroy(key);

            Debug.Log("YOU WIN!!");
        }
    }
}