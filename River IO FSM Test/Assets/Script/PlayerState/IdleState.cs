using UnityEngine;

public class IdleState : NinjaState
{
    public IdleState(NinjaController ninjaController, NinjaFiniteStateMachine finiteStateMachine)
      : base(ninjaController, finiteStateMachine) { }

    public override void Enter()
    {
        Debug.Log("Idle masuk");
        ninjaController.animator.SetBool("isIdle", true);
    }

    public override void Update()
    {
        if (!ninjaController.dying)
        {
            if (ninjaController.moveInput != 0)
            {
                finiteStateMachine.ChangeState(ninjaController.runState);
            }
            else if (ninjaController.jumping)
            {
                finiteStateMachine.ChangeState(ninjaController.jumpState);
            }
            else if (ninjaController.hurting)
            {
                finiteStateMachine.ChangeState(ninjaController.hurtState);
            }
            else if (ninjaController.attacking)
            {
                finiteStateMachine.ChangeState(ninjaController.attackState);
            }
        }
        else
        {
            finiteStateMachine.ChangeState(ninjaController.dieState);
        }

    }

    public override void Exit()
    {
        ninjaController.animator.SetBool("isIdle", false);
        Debug.Log("Idle keluar");
    }
}


