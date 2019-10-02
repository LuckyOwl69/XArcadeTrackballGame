using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    Vector3 originalPos;

    void Awake()
    {
        originalPos = gameObject.transform.position;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == ("Enemy"))
        {
            gameObject.transform.position = originalPos;

            Debug.Log("TRY AGAIN!!");
        }
    }
}