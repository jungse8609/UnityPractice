using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;

    [SerializeField] private Vector2 _inputVector;

    //These fields are read and manipulated by the StateMachine actions
    public Vector3 movementInput;
    public Vector3 movementVector;

    private float speed = 2.0f;

    private void OnEnable()
    {
        _inputReader.MoveEvent += OnMovement;
        Debug.Log("¸Ô¿©");
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
        transform.Translate(_inputVector);
    }

    /* --- Event Listener --- */

    private void OnMovement(Vector2 movement)
    {
        Debug.Log("moveevent ¸®½¼");
        _inputVector = movement;
    }
}
