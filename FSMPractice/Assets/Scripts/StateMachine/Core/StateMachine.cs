using UnityEngine;

namespace Test.StateMachine
{
    public class StateMachine : MonoBehaviour
    {
        [Tooltip("Set the initial state of this StateMachine")]
        [SerializeField] private ScriptableObjects.TransitionTableSO _transitionTableSO = default;

        internal State _currentState = default;

        private void Start()
        {
            //_currentState = skill1State;

            _currentState.OnStateEnter();
        }

        private void Update()
        {
            _currentState.OnUpdate();
        }

        void Transition(State state)
        {
            _currentState.OnStateExit();
            _currentState = state;
            _currentState.OnStateEnter();
        }
    }
}

