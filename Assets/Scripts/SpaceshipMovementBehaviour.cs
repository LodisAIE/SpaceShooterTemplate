using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovementBehaviour : MonoBehaviour
{
    private Vector2 _moveDirection;
    [SerializeField]
    private float _movementSpeed;
    private Vector2 _velocity;

    public Vector2 MoveDirection { get => _moveDirection; set => _moveDirection = value; }
    public Vector2 Velocity { get => _velocity; private set => _velocity = value; }
    public float MovementSpeed { get => _movementSpeed; set => _movementSpeed = value; }

    // Update is called once per frame
    void FixedUpdate()
    {
        Velocity = _moveDirection * MovementSpeed * Time.deltaTime;
        transform.position += new Vector3(Velocity.x, Velocity.y, 0);
    }
}
