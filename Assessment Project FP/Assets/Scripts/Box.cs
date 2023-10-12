using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour, Interactable
{
    public void Interact()
    {
        Debug.Log("Box was moved");
    }
}
