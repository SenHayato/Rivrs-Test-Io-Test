using UnityEngine;

namespace PlayerStates
{
    public class HurtState : NinjaState
    {
        public HurtState(NinjaController ninjaController, NinjaFiniteStateMachine finiteStateMachine)
            : base(ninjaController, finiteStateMachine) { }

        public override void Enter()
        {
            ninjaController.spriteRenderer.color = Color.red;
            ninjaController.animator.SetTrigger("isHurt");
            Debug.Log("Kena Damage");
        }

        public override void Exit()
        {
            ninjaController.hurting = false;
            ninjaController.spriteRenderer.color = Color.white;
            Debug.Log("Abis Kena Damage");
        }
    }
}

