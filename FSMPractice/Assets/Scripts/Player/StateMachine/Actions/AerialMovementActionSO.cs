using UnityEngine;
using Test.StateMachine;
using Test.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "AerialMovementAction", menuName = "State Machines/Actions/Aerial Movement Action")]
public class AerialMovementActionSO : StateActionSO
{
	protected override StateAction CreateAction() => new AerialMovementAction();
}

public class AerialMovementAction : StateAction
{
	protected new AerialMovementActionSO OriginSO => (AerialMovementActionSO)base.OriginSO;
	
	public override void OnUpdate()
	{
        Debug.Log("Move Action");
    }
}
