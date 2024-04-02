using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [NonSerialized] public Vector3 movementVector; //Final movement vector, manipulated by the StateMachine actions
}
