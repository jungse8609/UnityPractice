using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "InputReader", menuName = "Game/Input Reader")]
public class InputReader : ScriptableObject, GameInput.IGameplayActions
{
    // GamePlay
    public event UnityAction<Vector2> MoveEvent = delegate { };

    private GameInput _gameInput;

    private void OnEnable()
    {
        if (_gameInput == null)
        {
            _gameInput = new GameInput();

            _gameInput.Gameplay.SetCallbacks(this);
        }
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        Debug.Log("moveevent Input Reader");
        MoveEvent.Invoke(context.ReadValue<Vector2>());
    }
}
