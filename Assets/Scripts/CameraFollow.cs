using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 _offset;

    // The target that the camera is following
    [SerializeField] private Transform _target;

    // How smoothly the camera follows the player
    [SerializeField] private float _smoothTime;

    private Vector3 _currentVeloity = Vector3.zero;

    // Getting the target
    public Transform GetTarget { get { return _target; } }


    private void Awake()
    {
        _offset = transform.position - _target.position;
    }

    private void FixedUpdate()
    {
        Vector3 targetPosition = _target.position + _offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _currentVeloity, _smoothTime);
    }
}
