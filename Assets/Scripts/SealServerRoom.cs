using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealServerRoom : MonoBehaviour
{
    public GameObject myDoor;
    public GameObject myDoor2;
    public GameObject myDoor3;
    public ClipboardHint clipboard;
    private bool alreadyEntered = false;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (!alreadyEntered)
            {
                alreadyEntered = true;
                clipboard.UpdateHint("Find the flashlight. \nUse it to find the hidden code.");
            }
            myDoor.SetActive(true);
            myDoor2.SetActive(true);
            myDoor3.SetActive(true);
        }
    }
}
