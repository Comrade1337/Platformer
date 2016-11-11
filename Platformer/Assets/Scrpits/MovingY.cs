using UnityEngine;

public class MovingY : MonoBehaviour
{
    public float delta;
    public float speed;

    Vector3 _startPosition;
    Vector3 _finishPosition;
    bool movingUp;

    void Awake()
    {
        if (delta > 0)
        {
            _startPosition = transform.position;
            _finishPosition.y = _startPosition.y + delta;
        }
        else
        {
            _startPosition.y = _startPosition.y + delta;
            _finishPosition = transform.position;
        }
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