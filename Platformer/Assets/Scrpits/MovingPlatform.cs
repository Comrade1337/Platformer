using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour
{
    public float delta;
    public float speed = 0.05f;

    Vector3 _startPosition;
    float _finishPosition;
    bool movingUp;

    void Awake()
    {
        _startPosition = transform.position;
        _finishPosition = _startPosition.y + delta;
    }
    
    void FixedUpdate()
    {
        if (transform.position.y >= _finishPosition)
            movingUp = false;
        if (transform.position.y <= _startPosition.y)
            movingUp = true;

        transform.position += movingUp ? new Vector3(0, speed, 0) : new Vector3(0, -speed, 0);
    }
}
