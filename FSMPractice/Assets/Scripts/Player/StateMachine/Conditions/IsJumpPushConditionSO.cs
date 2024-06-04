using UnityEngine;
using Test.StateMachine;
using Test.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "IsJumpPushCondition", menuName = "State Machines/Conditions/Is Jump Push Condition")]
public class IsJumpPushConditionSO : StateConditionSO
{
	protected override Condition CreateCondition() => new IsJumpPushCondition();
}

public class IsJumpPushCondition : Condition
{
	protected new IsJumpPushConditionSO OriginSO => (IsJumpPushConditionSO)base.OriginSO;
    private Player _player;

	public override void Awake(StateMachine stateMachine)
	{
        _player = stateMachine.GetComponent<Player>();
	}
	
	protected override bool Statement()
	{
		return true;
	}
	
	public override void OnStateEnter()
	{
	}
	
	public override void OnStateExit()
	{
	}
}
