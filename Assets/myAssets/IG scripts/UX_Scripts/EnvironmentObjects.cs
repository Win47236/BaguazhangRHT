using UnityEngine;

public class EnvironmentObjects : MonoBehaviour
{
    private void Start()
    {
        // Assuming your environment objects are tagged as "environment"
        gameObject.tag = "environment";

        // Assign the "EnvironmentColliders" layer to the object
        gameObject.layer = LayerMask.NameToLayer("EnvironmentColliders");

        // Make sure collisions between objects on the "EnvironmentColliders" layer are disabled
        Physics.IgnoreLayerCollision(LayerMask.NameToLayer("EnvironmentColliders"), LayerMask.NameToLayer("EnvironmentColliders"));
    }
}
