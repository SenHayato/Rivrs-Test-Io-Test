using UnityEngine;

public class NinjaFiniteStateMachine
{
    public NinjaState currentState { get; private set; } //state ninja realtime

    public void Initialize(NinjaState startState)
    {
        currentState = startState;
        currentState.Enter();
    }

    public void ChangeState(NinjaState newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }
}
