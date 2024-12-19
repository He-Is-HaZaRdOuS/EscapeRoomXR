using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActivatePartyHatPuzzle : MonoBehaviour
{

    public GameObject partyHat;
    public GameObject button;
    public ClipboardHint clipboard;
    public string hint = "Find the party hat. \nSacrafice it to the flames.";
    public TextMeshPro secretButtonHint;
    private bool alreadyEntered = false;

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (!alreadyEntered)
            {
                alreadyEntered = true;
                clipboard.UpdateHint(hint);
            }
            partyHat.SetActive(true);
            button.SetActive(true);
            secretButtonHint.text = "Secret button   -->";
        }
    }
}
