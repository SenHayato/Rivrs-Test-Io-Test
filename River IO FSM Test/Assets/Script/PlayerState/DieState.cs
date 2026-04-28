using UnityEngine;

namespace PlayerStates
{
    public class DieState : NinjaState
    {
        public DieState(NinjaController ninjaController, NinjaFiniteStateMachine finiteStateMachine)
           : base(ninjaController, finiteStateMachine) { }

        public override void Enter()
        {
            ninjaController.animator.SetBool("isDie", true);
        }

        public override void Exit()
        {
            ninjaController.animator.SetBool("isDie", false);
        }
    }

}
