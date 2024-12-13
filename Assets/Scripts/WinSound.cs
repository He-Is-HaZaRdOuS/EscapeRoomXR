using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class WinSound : MonoBehaviour
{
    public AudioSource audioSource;
    private bool alreadyPlayed = false;

    void OnTriggerEnter(Collider other)
    {
        if (alreadyPlayed == false)
        {
            if (other.tag == "Player" && !audioSource.isPlaying)
            {
                audioSource.Play();
                alreadyPlayed = true;
            }
        }
    }
}
