using UnityEngine;
using Pudding.StateMachine;
using Pudding.StateMachine.ScriptableObjects;
using static UnityEditor.Experimental.GraphView.GraphView;

[CreateAssetMenu(fileName = "PullRopeAction", menuName = "State Machines/Actions/Pull Rope Action")]
public class PullRopeActionSO : StateActionSO
{
	protected override StateAction CreateAction() => new PullRopeAction();
}

public class PullRopeAction : StateAction
{
	protected new PullRopeActionSO _originSO => (PullRopeActionSO)base.OriginSO;
	private Player _player;
	private InteractionManager _interactionManager;

	public override void Awake(StateMachine stateMachine)
	{
        _player = stateMachine.GetComponent<Player>();
        _interactionManager = stateMachine.GetComponent<InteractionManager>();
	}
	
	public override void OnUpdate()
	{
		_interactionManager.currentInteractiveObject.transform.position = _player.transform.position;

    }
	
	public override void OnStateEnter()
	{
	}
	
	public override void OnStateExit()
	{
	}
}
