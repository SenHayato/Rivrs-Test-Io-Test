using UnityEngine;

public class DieState : NinjaState
{
    public DieState(NinjaController ninjaController, NinjaFiniteStateMachine finiteStateMachine)
       : base(ninjaController, finiteStateMachine) { }

    public override void Enter()
    {
        ninjaController.animator.SetBool("isDie", true);
        ninjaController.dying = true;
    }

    public override void Exit()
    {
        ninjaController.dying = false;
        ninjaController.animator.SetBool("isDie", false);
    }
}


