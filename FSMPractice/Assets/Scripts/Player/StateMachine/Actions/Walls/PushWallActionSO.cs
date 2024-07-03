﻿using UnityEngine;
using Test.StateMachine;
using Test.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "PushWallAction", menuName = "State Machines/Actions/Push Wall Action")]
public class PushWallActionSO : StateActionSO<PushWallAction> 
{
	public float pushForce = 10.0f;
}

public class PushWallAction : StateAction
{
	protected new PushWallActionSO _originSO => (PushWallActionSO)base.OriginSO;
	private InteractionManager _interactionManager;

	private Player _player;
	private Transform _transform;

	public override void Awake(StateMachine stateMachine)
	{
		_player = stateMachine.GetComponent<Player>();
		_transform = stateMachine.GetComponent<Transform>();
		_interactionManager = stateMachine.GetComponent<InteractionManager>();
	}

    public override void OnStateExit()
	{
		_interactionManager.currentInteractionType = InteractionType.None;
		_interactionManager.currentInteractiveObject = null;
	}

	public override void OnUpdate()
	{
		_transform.rotation = Quaternion.LookRotation(new Vector3(0,0,0));
		_player.movementVector.y = _originSO.pushForce;
	}
	
}
