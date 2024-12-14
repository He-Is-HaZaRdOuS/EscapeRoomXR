using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealServerRoom : MonoBehaviour
{
    public GameObject myDoor;
    public GameObject myDoor2;
    public GameObject myDoor3;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            myDoor.SetActive(true);
            myDoor2.SetActive(true);
            myDoor3.SetActive(true);
        }
    }
}
