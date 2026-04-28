using System.Collections;
using UnityEngine;

namespace PlayerStates
{
    public class JumpState : NinjaState
    {
        public JumpState(NinjaController ninjaController, NinjaFiniteStateMachine finiteStateMachine)
         : base(ninjaController, finiteStateMachine) { }

        public override void Enter()
        {
            Debug.Log("Jump masuk");
            ninjaController.animator.SetBool("isJumping", true);
            ninjaController.grounded = false;
            ninjaController.myRigidbody.linearVelocity = new(ninjaController.moveInput * 3f, 13f);
        }

        public override void Update()
        {
            Debug.Log("Jump Teros");

            if (ninjaController.grounded)
            {
                finiteStateMachine.ChangeState(ninjaController.idleState);
            }
            else if (ninjaController.hurting)
            {
                finiteStateMachine.ChangeState(ninjaController.hurtState);
            }
        }

        public override void Exit()
        {
            ninjaController.animator.SetBool("isJumping", false);
            ninjaController.jumping = false;
            Debug.Log("Jump keluar");
        }
    }

}
