using UnityEngine;
using UnityEngine.InputSystem;

public class TopDownCharacterController2D : MonoBehaviour
{
    [SerializeField]
    private PlayerInput _playerInput = default(PlayerInput);
    [SerializeField]
    private Rigidbody2D _rigidbody;
    [SerializeField]
    private float _movementSpeed = 1f;

    private Vector2 moveAmount = new Vector2();


    public void Update()
    {
        Move();
    }


    public void OnMove(InputAction.CallbackContext context)
    {
        // read the value for the "move" action each event call
        moveAmount = context.ReadValue<Vector2>();
    }


    private void Move()
    {
        // to use the Vector2 value from the "move" action each
        // frame, use the "moveAmount" variable here.
        var movement = _rigidbody.position + moveAmount * _movementSpeed;
        _rigidbody.MovePosition(movement);
    }
}
