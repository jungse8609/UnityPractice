using System;
using UnityEngine;

namespace Test.StateMachine.ScriptableObjects
{
    [CreateAssetMenu(fileName = "NewTransitionTable", menuName = "State Machines/Transition Table")]
    public class TransitionTableSO : ScriptableObject
    {
        [SerializeField] private TransitionItem[] _transitions = default;

        [Serializable]
        public struct TransitionItem
        {
            public StateSO FromState;
            public StateSO ToState;
            public ConditionUsage[] Conditions;
        }

        [Serializable]
        public struct ConditionUsage
        {
            public Result ExpectedResult;
            public StateConditionSO Condition;
            public Operator Operator;
        }

        public enum Result { True, False }
        public enum Operator { And, Or }
    }
}
