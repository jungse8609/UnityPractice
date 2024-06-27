using UnityEngine;
using Test.StateMachine;
using Test.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "isPushingLightCondition", menuName = "State Machines/Conditions/is Pushing Light Condition")]
public class isPushingLightConditionSO : StateConditionSO<isPushingLightCondition> { }

public class isPushingLightCondition : Condition
{
	protected new isPushingLightConditionSO OriginSO => (isPushingLightConditionSO)base.OriginSO;
	private InteractionManager _interactionManager;

	public override void Awake(StateMachine stateMachine)
	{
		_interactionManager = stateMachine.GetComponent<InteractionManager>();
	}

	protected override bool Statement() => _interactionManager.pushInput;
}
