using UnityEngine;
using Test.StateMachine;
using Test.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "isPullingLightCondition", menuName = "State Machines/Conditions/is Pulling Light Condition")]
public class isPullingLightConditionSO : StateConditionSO
{
	protected override Condition CreateCondition() => new isPullingLightCondition();
}

public class isPullingLightCondition : Condition
{
	protected new isPullingLightConditionSO OriginSO => (isPullingLightConditionSO)base.OriginSO;

	public override void Awake(StateMachine stateMachine)
	{
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
