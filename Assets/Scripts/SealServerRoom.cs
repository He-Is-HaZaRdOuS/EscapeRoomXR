using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealServerRoom : MonoBehaviour
{
    public GameObject myDoor;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            myDoor.SetActive(true);
        }
    }
}
