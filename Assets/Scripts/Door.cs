using System;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject OpenDoor;
    [SerializeField] private GameObject closeDoor;
    void Start()
    {
        OpenDoor.SetActive(false);
        closeDoor.SetActive(true);
    }
}
