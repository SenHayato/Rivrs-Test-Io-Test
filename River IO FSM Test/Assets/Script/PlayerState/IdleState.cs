using UnityEngine;

namespace PlayerStates
{
    public class IdleState : NinjaState
    {
        public IdleState(NinjaController ninjaController, NinjaFiniteStateMachine finiteStateMachine)
          : base(ninjaController, finiteStateMachine) { }

        public override void Enter()
        {
            Debug.Log("Idle masuk");
            ninjaController.animator.SetBool("isIdle", true);
            base.Enter();
        }

        public override void Update()
        {
            if (ninjaController.moveInput != 0)
            {
                finiteStateMachine.ChangeState(ninjaController.runState);
            }
        }

        public override void Exit()
        {
            ninjaController.animator.SetBool("isIdle", false);
            Debug.Log("Idle keluar");
            base.Exit();
        }
    }
}

