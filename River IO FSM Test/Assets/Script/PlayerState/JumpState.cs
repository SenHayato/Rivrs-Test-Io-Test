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
        }

        public override void Update()
        {
            Debug.Log("Jump Teros");

            //if (ninjaController.jumping && !ninjaController.grounded)
            //{
            //    PlayerJump();
            //}
            //else
            //{
            //    Exit();
            //}
        }

        public override void Exit()
        {
            ninjaController.animator.SetBool("isJumping", false);
            ninjaController.jumping = false;
            Debug.Log("Jump keluar");
            return;
        }
    }

}
