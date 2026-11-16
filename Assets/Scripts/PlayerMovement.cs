using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player Settings")]
    [SerializeField] private float _moveSpeed = 12.5f;
    [SerializeField] private float _jumpForce = 10.0f;

    // Boolean to determine if the player is on the ground
    private bool _grounded;
    // Standard float for horizontal movement
    private float _horizontal;
    // Standard float for up and down vertical movement along the z axis
    private float _vertical;
    // Reference to the rigidbody component on our player
    private Rigidbody _playerRB;

    private void Start()
    {
        // Getting the rigidbody component on our player
        _playerRB = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // Setting our rigidbody's velocity to our float multiplied by the movement speed.
        _playerRB.linearVelocity = new Vector3(_horizontal * _moveSpeed, _playerRB.linearVelocity.y, _vertical * _moveSpeed);
    }

    public void Move(InputAction.CallbackContext context)
    {
        // Setting our floats to the controls
        _horizontal = context.ReadValue<Vector2>().x;
        _vertical = context.ReadValue<Vector2>().y;
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _playerRB.linearVelocity = new Vector3(0, _jumpForce, 0);
        }
    }
}
