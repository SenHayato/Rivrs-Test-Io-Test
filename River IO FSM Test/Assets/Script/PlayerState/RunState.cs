using UnityEngine;

public class RunState : NinjaState
{
    public RunState(NinjaController ninjaController, NinjaFiniteStateMachine finiteStateMachine)
     : base(ninjaController, finiteStateMachine) { }

    public override void Enter()
    {
        Debug.Log("Run masuk");
        ninjaController.animator.SetBool("isRunning", true);
        //base.Enter();
    }

    public override void Update()
    {
        ninjaController.transform.Translate(Vector2.right * ninjaController.moveInput * ninjaController.moveSpeed * Time.deltaTime);
        if (ninjaController.moveInput == 0)
        {
            finiteStateMachine.ChangeState(ninjaController.idleState);
        }
        else if (ninjaController.jumping)
        {
            finiteStateMachine.ChangeState(ninjaController.jumpState);
        }
        else if (ninjaController.attacking)
        {
            finiteStateMachine.ChangeState(ninjaController.attackState);
        }
        else if (ninjaController.dying)
        {
            finiteStateMachine.ChangeState(ninjaController.dieState);
        }

        //flip
        if (ninjaController.moveInput > 0.1f)
        {
            ninjaController.spriteRenderer.flipX = false;
        }
        else if (ninjaController.moveInput < -0.1f)
        {
            ninjaController.spriteRenderer.flipX = true;
        }
    }

    public override void Exit()
    {
        Debug.Log("Run keluar");
        ninjaController.animator.SetBool("isRunning", false);
    }
}


