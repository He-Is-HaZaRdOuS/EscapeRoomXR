using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealWhiteRoom : MonoBehaviour
{
    public GameObject myDoor;
    public GameObject myDoor2;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            myDoor.SetActive(true);
            myDoor2.SetActive(true);
        }
    }
}
