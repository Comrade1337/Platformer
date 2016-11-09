using UnityEngine;

public class SawAnimation : MonoBehaviour
{
    void Update()
    {
        if (!Data.Paused)
            transform.Rotate(new Vector3(0f, 0f, 2f));
    }
}
