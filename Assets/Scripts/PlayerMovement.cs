using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player Settings")]
    [SerializeField] private float _moveSpeed = 10.0f;

    // Standard float for horizontal movemepnt
    private float _horizontal;
    private Rigidbody _playerRB;

    private void Start()
    {
        _playerRB = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _playerRB.velocity = new Vector2(_horizontal * _moveSpeed, _playerRB.velocity.y);
    }

    public void Move(InputAction.CallbackContext context)
    {
        _horizontal = context.ReadValue<Vector2>().x;
    }
}
