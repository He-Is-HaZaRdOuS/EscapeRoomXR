using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class WinSound : MonoBehaviour
{
    public AudioSource audioSource;
    public ClipboardHint clipboard;
    private bool alreadyPlayed = false;

    void OnTriggerEnter(Collider other)
    {
        if (alreadyPlayed == false)
        {
            if (other.tag == "Player" && !audioSource.isPlaying)
            {
                audioSource.Play();
                alreadyPlayed = true;
                clipboard.UpdateHint("Escape successful! \nYou are free! \n...\nWe're in outer space now? \n\nWell, at least you found this impossibly non-euclidean cube to keep you company...");
            }
        }
    }
}
