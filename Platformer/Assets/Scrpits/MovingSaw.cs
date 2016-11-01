using UnityEngine;
using System.Collections;

public class MovingSaw : MonoBehaviour {
    public float delta;
    public float speed = 0.05f;
    public bool movingOnX;
    public bool movingOnY;

    Vector3 _startPosition;
    Vector3 _finishPosition;
    bool movingUp;

    void Awake()
    {
        _startPosition = transform.position;
        _finishPosition.y = _startPosition.y + delta;
    }

    void FixedUpdate()
    {
        if (transform.position.y >= _finishPosition.y)
            movingUp = false;
        if (transform.position.y <= _startPosition.y)
            movingUp = true;

        transform.position += movingUp && _startPosition.y < _finishPosition.y ? new Vector3(0, speed, 0) : new Vector3(0, -speed, 0);
    }
}
