using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Box : MonoBehaviour, Interactable
{
    public Key key;
    public Interactor interactor;
    //public Text keyMessage;
    public void Interact()
    {
        key.KeyInHand = true;
    }

}