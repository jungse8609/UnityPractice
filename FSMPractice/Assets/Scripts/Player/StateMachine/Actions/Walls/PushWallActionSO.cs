using UnityEngine;
using Test.StateMachine;
using Test.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "PushWallAction", menuName = "State Machines/Actions/Push Wall Action")]
public class PushWallActionSO : StateActionSO<PushWallAction> 
{
	public float pushForce = 3.0f;
	public float pushHeight = 0.9f;
	public LayerMask floorLayerMask;
}

public class PushWallAction : StateAction
{
	protected new PushWallActionSO _originSO => (PushWallActionSO)base.OriginSO;
	private InteractionManager _interactionManager;
	private Rigidbody _interactiveObjectRigidbody;

	public override void Awake(StateMachine stateMachine)
	{
		_interactionManager = stateMachine.GetComponent<InteractionManager>();
	}
	
	public override void OnStateExit()
	{
		_interactionManager.currentInteractionType = InteractionType.None;
		_interactionManager.currentInteractiveObject = null;
	}

	public override void OnUpdate()
	{

	}
	
}
