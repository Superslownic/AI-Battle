namespace CustomStateMachine
{
    public abstract class State
    {
        protected IStateChanger _stateMachine;

        public State(IStateChanger stateMachine)
        {
            _stateMachine = stateMachine;
        }

        public virtual void Enter() { }
        public virtual void Update() { }
        public virtual void Exit() { }
    }
}
