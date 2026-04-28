using UnityEngine;

public abstract class NinjaState
{
    protected NinjaController ninjaController;
    protected NinjaFiniteStateMachine finiteStateMachine;

    public NinjaState(NinjaController ninjaControl, NinjaFiniteStateMachine finiteSM)
    {
        this.ninjaController = ninjaControl;
        this.finiteStateMachine = finiteSM;
    }

    public virtual void Enter() { }
    public virtual void Update() { }
    public virtual void Exit() { }
}
