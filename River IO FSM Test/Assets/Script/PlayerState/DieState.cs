using UnityEngine;

namespace PlayerStates
{
    public class DieState : NinjaState
    {
        public DieState(NinjaController ninjaController, NinjaFiniteStateMachine finiteStateMachine)
           : base(ninjaController, finiteStateMachine) { }

        public override void Enter()
        {
            base.Enter();
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Exit()
        {
            base.Exit();
        }
    }

}
