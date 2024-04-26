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

    protected override bool Statement()
    {
        if (Input.GetMouseButton(0))
            return true;
        return false;
    }
}


