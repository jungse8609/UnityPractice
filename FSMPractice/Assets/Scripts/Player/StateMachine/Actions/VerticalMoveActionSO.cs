using UnityEngine;
using Pudding.StateMachine;
using Pudding.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "VerticalMoveAction", menuName = "State Machines/Actions/Vertical Move Action")]
public class VerticalMoveActionSO : StateActionSO<VerticalMoveAction>
{
	public float speed;
}

public class VerticalMoveAction : StateAction
{
	private VerticalMoveActionSO _originSO => (VerticalMoveActionSO)base.OriginSO;
    private Player _player;

    public override void Awake(StateMachine stateMachine)
    {
        _player = stateMachine.GetComponent<Player>();
    }

    public override void OnStateEnter()
    {
        
    }

    public override void OnUpdate()
    {
        _player.movementVector.y = _player.movementInput.z * _originSO.speed;
    }
}
