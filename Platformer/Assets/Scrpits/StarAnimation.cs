using UnityEngine;
using System.Collections;

public class StarAnimation : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, 0.5f));
    }
}
