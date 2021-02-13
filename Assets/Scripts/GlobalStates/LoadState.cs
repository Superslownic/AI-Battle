using CustomStateMachine;

namespace AIBattle
{
    public class LoadState : State
    {
        public LoadState(StateMachine stateMachine) : base(stateMachine) { }

        public override void Enter()
        {
            _stateMachine.SetState<GameState>();
        }
    }
}
