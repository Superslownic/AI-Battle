namespace CustomStateMachine
{
    public interface IStateChanger
    {
        void SetState<T>() where T : State;
    }
}
