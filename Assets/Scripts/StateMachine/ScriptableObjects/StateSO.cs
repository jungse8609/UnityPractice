using System.Collections.Generic;
using UnityEngine;

namespace Test.StateMachine.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New State", menuName = "State Machines/State")]
    public class StateSO : ScriptableObject
    {
        internal State GetState(StateMachine stateMachine, Dictionary<ScriptableObject, object> createdInstances)
        {
            if (createdInstances.TryGetValue(this, out var obj))
                return (State)obj;

            var state = new State();
            createdInstances.Add(this, state);

            return state;
        }
    }
}
