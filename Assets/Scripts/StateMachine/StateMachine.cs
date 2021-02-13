using System;
using System.Collections.Generic;
using UnityEngine;

namespace CustomStateMachine
{
    public abstract class StateMachine : MonoBehaviour, IStateChanger
    {
        private Dictionary<Type, State> _states;
        private State _currentState;
        
        void IStateChanger.SetState<T>()
        {
            _currentState?.Exit();
            _currentState = _states[typeof(T)];
            _currentState.Enter();
#if UNITY_EDITOR
            Debug.Log($"State changed to {typeof(T).Name}");
#endif
        }

        public StateMachine AddState(State state)
        {
            _states.Add(state.GetType(), state);
            return this;
        }

        protected abstract void SetupStates();

        private void Awake()
        {
            _states = new Dictionary<Type, State>();
            SetupStates();
        }

        private void Update()
        {
            _currentState.Update();
        }
    }
}
