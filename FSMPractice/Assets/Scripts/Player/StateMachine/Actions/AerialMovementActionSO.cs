using UnityEngine;
using Test.StateMachine;
using Test.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "AerialMovementAction", menuName = "State Machines/Actions/Aerial Movement Action")]
public class AerialMovementActionSO : StateActionSO
{
    public float Speed => _speed;

    [SerializeField] [Range(0.1f, 100.0f)] private float _speed = 10.0f;

	protected override StateAction CreateAction() => new AerialMovementAction();
}

public class AerialMovementAction : StateAction
{
	protected new AerialMovementActionSO OriginSO => (AerialMovementActionSO)base.OriginSO;

	private Player _player;

    public override void Awake(StateMachine stateMachine)
    {
        _player = stateMachine.GetComponent<Player>();
    }

    public override void OnUpdate()
	{
        Vector3 velocity = _player.movementVector;
        Vector3 input = _player.movementInput;
        float speed = OriginSO.Speed;

        _player.transform.Translate(_player.movementInput);
    }
}
