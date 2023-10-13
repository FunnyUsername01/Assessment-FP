using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoorScript : MonoBehaviour
{
    public GameManager manager;
    public GameObject lockedDoorUI;
    public GameObject unlockedDoorUI;
    public DoorScript door;
    public Key key;

    // Update is called once per frame
    void Update()
    {
        if(door.doorTouch == true && key.KeyInHand == false) 
        {
            doorLockedMessage();
            door.doorTouch = false;
        }

        if (door.doorTouch == true && key.KeyInHand == true)
        {
            Debug.Log("You escaped!");
            Escaped();
            if (Input.GetKeyDown(KeyCode.Q))
            {
                manager.Restart();
            }
        }
    }

    public void doorLockedMessage()
    {
        lockedDoorUI.SetActive(true);
    }
    public void DoorUnLocked()
    {
        lockedDoorUI.SetActive(false);
    }

    public void Escaped()
    {
        unlockedDoorUI.SetActive(true);
    }
}
