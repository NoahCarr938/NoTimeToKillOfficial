using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player Settings")]
    [SerializeField] private float _moveSpeed = 10.0f;

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
        _playerRB.velocity = new Vector3(_horizontal * _moveSpeed, 0, _vertical * _moveSpeed);
    }

    public void Move(InputAction.CallbackContext context)
    {
        // Setting our floats to the controls
        _horizontal = context.ReadValue<Vector2>().x;
        _vertical = context.ReadValue<Vector2>().y;
    }
}
