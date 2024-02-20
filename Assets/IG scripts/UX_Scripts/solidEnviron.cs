using UnityEngine;

public class solidEnviron : MonoBehaviour
{
    void Start()
    {
        // Check if the object has the "environment" tag
        if (gameObject.CompareTag("environment"))
        {
            Rigidbody rb = GetComponent<Rigidbody>();

            // Freeze position and rotation on all axes
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}

