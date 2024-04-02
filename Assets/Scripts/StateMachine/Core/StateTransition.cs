namespace Test.StateMachine
{
    public class StateTransition : IStateComponent
    {
        private State _targetState;
        private StateCondition[] _conditions;

        public void OnStateEnter()
        {
            for (int i = 0; i < _conditions.Length; ++i)
                _conditions[i]._condition.OnStateEnter();
        }

        public void OnStateExit()
        {
            for (int i = 0; i < _conditions.Length; ++i)
                _conditions[i]._condition.OnStateExit();
        }
    }
}


