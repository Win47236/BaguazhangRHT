using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footStepSounds : MonoBehaviour
{
    public AudioSource footSteps; // Assign this in the inspector with your AudioSource
    private Vector3 lastPosition; // To keep track of the last position

    void Start()
    {
        lastPosition = transform.position; // Initialize lastPosition
        if (footSteps == null)
        {
            Debug.LogError("Footsteps audio source is not assigned!");
        }
    }

    void Update()
    {
        // Check if the player has moved by comparing the current position with the last known position
        if (transform.position != lastPosition)
        {
            if (!footSteps.isPlaying)
            {
                footSteps.Play(); // Play the footstep sound only if it is not already playing
            }
        }
        else
        {
            if (footSteps.isPlaying)
            {
                footSteps.Stop(); // Stop the footstep sound if there is no movement
            }
        }

        // Update lastPosition to the current position at the end of the frame
        lastPosition = transform.position;
    }
}
