using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public void KeyFound()
    {
        gameObject.SetActive(true);
    }

    public void KeyUsed()
    {
        gameObject.SetActive(false);
    }
}
