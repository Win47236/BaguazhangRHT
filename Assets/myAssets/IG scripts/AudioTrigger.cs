using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            PlayDoorBellSound();
        }
    }

    private void PlayDoorBellSound()
    {
        AudioSource doorBellAudioSource = GetComponent<AudioSource>();

        if (doorBellAudioSource != null && !doorBellAudioSource.isPlaying)
        {
            doorBellAudioSource.Play();
        }
    }
}
