using UnityEngine;
using Test.StateMachine;
using Test.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "JumpAscendingAction", menuName = "State Machines/Actions/Jump Ascending Action")]
public class JumpAscendingActionSO : StateActionSO
{
	protected override StateAction CreateAction() => new JumpAscendingAction();
}

public class JumpAscendingAction : StateAction
{
	protected new JumpAscendingActionSO OriginSO => (JumpAscendingActionSO)base.OriginSO;
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
