using UnityEngine;
using Test.StateMachine;
using Test.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "PullLightAction", menuName = "State Machines/Actions/PullLightAction")]
public class PullLightActionSO : StateActionSO<PullLightAction> { }

public class PullLightAction : StateAction
{
	protected new PullLightActionSO _originSO => (PullLightActionSO)base.OriginSO;
	private Player _player;
	private InteractionManager _interactionManager;

	public override void Awake(StateMachine stateMachine)
	{
		_player = stateMachine.GetComponent<Player>();
        _interactionManager = stateMachine.GetComponent<InteractionManager>();
    }
	
	public override void OnUpdate()
	{
        _interactionManager.currentInteractiveObject.transform.position = _player.transform.position + _player.transform.right * 2.0f;
    }
}
