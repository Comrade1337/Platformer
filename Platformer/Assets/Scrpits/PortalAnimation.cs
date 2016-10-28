using UnityEngine;

public class PortalAnimation : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, -.5f));
    }
}
