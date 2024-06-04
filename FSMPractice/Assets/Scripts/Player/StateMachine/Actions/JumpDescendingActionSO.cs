using UnityEngine;
using Test.StateMachine;
using Test.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "JumpDescendingAction", menuName = "State Machines/Actions/Jump Descending Action")]
public class JumpDescendingActionSO : StateActionSO
{
	protected override StateAction CreateAction() => new JumpDescendingAction();
}

public class JumpDescendingAction : StateAction
{
	protected new JumpDescendingActionSO OriginSO => (JumpDescendingActionSO)base.OriginSO;
	private Player _player;

	public override void Awake(StateMachine stateMachine)
	{
        _player = stateMachine.GetComponent<Player>();
	}
	
	public override void OnUpdate()
	{
	}
	
	public override void OnStateEnter()
	{
	}
	
	public override void OnStateExit()
	{
	}
}
