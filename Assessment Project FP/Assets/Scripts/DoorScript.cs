using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour, Interactable
{
    public bool doorTouch;
    public void Interact()
    {
        Debug.Log("ass");
        doorTouch = true;
    }
}
