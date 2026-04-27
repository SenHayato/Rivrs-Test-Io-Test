using UnityEngine;

namespace PlayerStates
{
    public class HurtState : NinjaState
    {
        public HurtState(NinjaController ninjaController, NinjaFiniteStateMachine finiteStateMachine)
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

