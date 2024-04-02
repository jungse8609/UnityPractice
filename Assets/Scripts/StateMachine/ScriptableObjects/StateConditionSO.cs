using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test.StateMachine.ScriptableObjects
{
    public abstract class StateConditionSO : ScriptableObject
    {
        protected abstract Condition CreateCondition();
    }

    public abstract class StateConditionSO<T> : StateConditionSO where T : Condition, new()
    {
        protected override Condition CreateCondition() => new T();
    }
}
