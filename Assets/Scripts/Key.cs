using UnityEngine;

public class Key : MonoBehaviour
{
    [Header("Doors")]
    [SerializeField] private GameObject OpenDoor;
    [SerializeField] private GameObject CloseDoor;

    [Header("Keys")]
    [SerializeField] private GameObject key;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            OpenDoor.SetActive(true);
            CloseDoor.SetActive(false);
            key.SetActive(false);
        }
    }

    void Update()
    {
        transform.Rotate(Vector3.up * 90f * Time.deltaTime, Space.Self);
    }
}
