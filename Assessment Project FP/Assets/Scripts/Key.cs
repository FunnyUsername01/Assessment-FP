using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public bool KeyInHand { get; set; }
    public GameObject keyUI;
    public UnlockDoorScript door;

    void Update()
    {
        if (KeyInHand == true)
        {
            KeyFound();
            door.DoorUnLocked();
        }
        else if (KeyInHand == false)
        {
            KeyLost();
        }
    }
    public void KeyFound()
    {
        keyUI.SetActive(true);
    }
    public void KeyLost()
    {
        keyUI.SetActive(false);
    }
}
