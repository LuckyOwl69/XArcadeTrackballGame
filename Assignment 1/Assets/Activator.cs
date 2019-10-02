using UnityEngine;

public class Activator : MonoBehaviour
{
    [SerializeField] private GameObject keyUnlockable;

    void Start()
    {
        keyUnlockable.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        keyUnlockable.SetActive(true);
    }
}