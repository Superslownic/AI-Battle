using CustomStateMachine;

namespace AIBattle
{
    public class GlobalStateMachine : StateMachine
    {
        protected override void SetupStates()
        {
            this.AddState(new LoadState(this))
                .AddState(new GameState(this));
        }
    }
}
