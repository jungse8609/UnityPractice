using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader = default;

    private Vector2 _inputVector; // _inputVector.x : x movement, _inputVector.y : z movement
    private float _previousSpeed;

    //These fields are read and manipulated by the StateMachine actions
    public Vector3 movementInput;
    public Vector3 movementVector;

    private float speed = 2.0f;

    public const float AIR_RESISTANCE = 5f;

    private void OnEnable()
    {
        _inputReader.MoveEvent += OnMovement;
    }

    private void OnDisable()
    {
        _inputReader.MoveEvent -= OnMovement;
    }

    private void Update()
    {
        RecalculateMovement();
    }

    private void RecalculateMovement()
    {
        float targetSpeed;
        Vector3 adjustedMovement;

        adjustedMovement = new Vector3(_inputVector.x, 0.0f, _inputVector.y);

        targetSpeed = Mathf.Clamp01(_inputVector.magnitude);
        targetSpeed = Mathf.Lerp(_previousSpeed, targetSpeed, Time.deltaTime * 4.0f);

        if (_inputVector.sqrMagnitude == 0.0f)
            adjustedMovement = transform.forward * (adjustedMovement.magnitude + .01f);

        movementInput = adjustedMovement * targetSpeed;

        _previousSpeed = targetSpeed;
    }

    /* --- Event Listener --- */

    private void OnMovement(Vector2 movement)
    {
        Debug.Log(movement);
        _inputVector = movement;
    }
}
