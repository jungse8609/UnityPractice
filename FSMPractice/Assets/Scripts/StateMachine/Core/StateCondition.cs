using Test.StateMachine.ScriptableObjects;

namespace Test.StateMachine
{
    public abstract class Condition : IStateComponent
    {
        internal StateConditionSO _originSO;
        protected StateConditionSO OriginSO => _originSO;

        protected abstract bool Statement();

        public virtual void Awake(StateMachine stateMachine) { }
        public virtual void OnStateEnter() { }
        public virtual void OnStateExit() { }
    }

    public struct StateCondition
    {
        internal StateMachine _stateMachine;
        internal Condition _condition;
        internal bool _expectedResult;

        public StateCondition(StateMachine stateMachine, Condition condition, bool expectedResult)
        {
            _stateMachine = stateMachine;
            _condition = condition;
            _expectedResult = expectedResult;
        }
    }
}

