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
            base.Enter();
        }

        public override void Update()
        {
            Debug.Log("Jump Teros");
        }

        public override void Exit()
        {
            Debug.Log("Jump keluar");
            base.Exit();
        }
    }

}
