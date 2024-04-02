using UnityEngine;

namespace Test.StateMachine
{
    public class State
    {
        internal StateMachine _stateMachine;
        internal StateTransition[] _transitions;

        internal State() { }

        public State(StateMachine stateMachine, StateTransition[] transitions)
        {
            _stateMachine = stateMachine;
            _transitions = transitions;
        }

        public void OnStateEnter()
        {
            void OnStateEnter(IStateComponent[] comps)
            {
                for (int i = 0; i < comps.Length; ++i)
                    comps[i].OnStateEnter();
            }

            OnStateEnter(_transitions);
        }

        public void OnStateExit()
        {
            void OnStateExit(IStateComponent[] comps)
            {
                for (int i = 0; i <= comps.Length; ++i)
                    comps[i].OnStateExit();
            }

            OnStateExit(_transitions);
        }

        public void OnUpdate()
        {

        }
    }
}

