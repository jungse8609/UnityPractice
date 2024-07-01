using UnityEngine;
using Test.StateMachine;
using Test.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "PullWallAction", menuName = "State Machines/Actions/Pull Wall Action")]

public class PullWallActionSO : StateActionSO<PullWallAction> 
{
    public LayerMask floorLayerMask;
}

public class PullWallAction : StateAction
{
	protected new PullWallActionSO _originSO => (PullWallActionSO)base.OriginSO;
	private Player _player;
	private InteractionManager _interactionManager;
	
	public override void Awake(StateMachine stateMachine)
	{
		_player = stateMachine.GetComponent<Player>();
        _interactionManager = stateMachine.GetComponent<InteractionManager>();
	}
	
	public override void OnUpdate()
	{
        _player.movementVector.y = 5.0f;

    	Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, _originSO.floorLayerMask))
        {
            Vector3 mousePosition = hit.point;
            mousePosition.y = _player.transform.position.y;

            Vector3 direction = (mousePosition - _player.transform.position).normalized;
            _interactionManager.currentInteractiveObject.transform.position = _player.transform.position + direction * 2.0f;

            _interactionManager.currentInteractiveObject.transform.LookAt(mousePosition);
        }
	}
}
