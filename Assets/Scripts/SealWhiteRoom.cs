using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealWhiteRoom : MonoBehaviour
{
    public GameObject myDoor;
    public GameObject myDoor2;
    public ClipboardHint clipboard;
    public string hint = "Take a good look at yourself.";
    private bool alreadyEntered = false;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (!alreadyEntered)
            {
                alreadyEntered = true;
                clipboard.UpdateHint(hint);
            }
            myDoor.SetActive(true);
            myDoor2.SetActive(true);
        }
    }
}
