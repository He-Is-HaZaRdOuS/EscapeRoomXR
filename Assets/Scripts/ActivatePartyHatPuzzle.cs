using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePartyHatPuzzle : MonoBehaviour
{

    public GameObject partyHat;
    public GameObject button;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            partyHat.SetActive(true);
            button.SetActive(true);
        }
    }
}
