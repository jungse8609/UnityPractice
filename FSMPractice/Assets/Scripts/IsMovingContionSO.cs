using UnityEngine;
using Test.StateMachine.ScriptableObjects;
using Test.StateMachine;

[CreateAssetMenu(menuName = "State Machines/Conditions/Started Moving")]
public class IsMovingConditionSO : StateConditionSO<IsMovingCondition>
{
    public float treshold = 0.02f;
}

public class IsMovingCondition : Condition
{
    private Player _playerScript;
    private IsMovingConditionSO _originSO => (IsMovingConditionSO)base.OriginSO;

    public override void Awake(StateMachine stateMachine)
    {
        _playerScript = stateMachine.GetComponent<Player>();
    }

    protected override bool Statement()
    {
        Vector3 movementVector = _playerScript.movementVector;
        movementVector.y = 0f;
        return movementVector.sqrMagnitude > _originSO.treshold;
    }
}


