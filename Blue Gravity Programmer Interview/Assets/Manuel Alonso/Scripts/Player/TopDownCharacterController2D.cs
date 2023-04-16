using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class TopDownCharacterController2D : MonoBehaviour
{
    //[SerializeField]
    //private PlayerInput _playerInput = default(PlayerInput);
    [SerializeField]
    private Rigidbody2D _rigidbody = default;
    [SerializeField]
    private float _movementSpeed = 1f;

    private Vector2 _moveAmount = new Vector2();
    private bool _flipX = false;


    public void Update()
    {
        Move();
    }


    public void OnMove(InputAction.CallbackContext context)
    {
        // read the value for the "move" action each event call
        _moveAmount = context.ReadValue<Vector2>();
        CheckFlip(_moveAmount);
    }


    private void Move()
    {
        // to use the Vector2 value from the "move" action each
        // frame, use the "moveAmount" variable here.
        var movement = _rigidbody.position + _moveAmount * _movementSpeed;
        _rigidbody.MovePosition(movement);
    }

    private void CheckFlip(Vector2 movement)
    {
        if (movement.x > 0)
        {
            if (_flipX)
            {
                Flip();
                _flipX = false;
            }
        }
        else if (movement.x < 0)
        {
            if (!_flipX)
            {
                Flip();
                _flipX = true;
            }
        }
    }

    private void Flip()
    {
        transform.localScale =
            new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
