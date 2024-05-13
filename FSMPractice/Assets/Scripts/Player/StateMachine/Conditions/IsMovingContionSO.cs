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
    private IsMovingConditionSO _originSO => (IsMovingConditionSO)base.OriginSO;

    private Player _player;


    public override void Awake(StateMachine stateMachine)
    {
        _player = stateMachine.GetComponent<Player>();
    }

    protected override bool Statement()
    {
        if (_player.movementInput != Vector3.zero)
            return true;
        return false;
    }
}


