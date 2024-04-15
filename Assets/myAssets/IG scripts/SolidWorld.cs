using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolidWorld : MonoBehaviour
{
    public GameObject objectToInstantiate; // Specify the prefab to instantiate

    Vector3 initialPosition;
    Quaternion initialRotation;
    float movementThreshold = 0.0001f;
    float rotationThreshold = 0.0001f;

    void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    void Update()
    {
        if (HasMovedBeyondThreshold() || HasRotatedBeyondThreshold())
        {
            InstantiateNewObject();
            Destroy(gameObject); // Destroy current object
        }
    }

    bool HasMovedBeyondThreshold()
    {
        float distanceMoved = Vector3.Distance(initialPosition, transform.position);
        return distanceMoved > movementThreshold;
    }

    bool HasRotatedBeyondThreshold()
    {
        Quaternion currentRotation = transform.rotation;
        float angleRotated = Quaternion.Angle(initialRotation, currentRotation);
        return angleRotated > rotationThreshold;
    }

    void InstantiateNewObject()
    {
        if (objectToInstantiate != null)
        {
            GameObject newObject = Instantiate(objectToInstantiate, initialPosition, initialRotation);
            // Ensure the new object has the SolidWorld script but not this instance's script
            Destroy(newObject.GetComponent<SolidWorld>());
        }
        else
        {
            Debug.LogWarning("Prefab for instantiation is not assigned!");
        }
    }
}

