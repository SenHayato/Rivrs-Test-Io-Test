using UnityEngine;

namespace PlayerStates
{
    public class AttackState : NinjaState
    {
        public AttackState(NinjaController ninjaController, NinjaFiniteStateMachine finiteStateMachine) 
            : base(ninjaController, finiteStateMachine) { }
        public override void Enter()
        {
            Debug.Log("Attack masuk");
            base.Enter();
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Exit()
        {
            Debug.Log("Attack keluar");
            base.Exit();
        }
    }
}

