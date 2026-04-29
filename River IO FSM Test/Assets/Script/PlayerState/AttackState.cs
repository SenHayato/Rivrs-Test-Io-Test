using UnityEngine;

public class AttackState : NinjaState
{
    public AttackState(NinjaController ninjaController, NinjaFiniteStateMachine finiteStateMachine)
        : base(ninjaController, finiteStateMachine) { }
    public override void Enter()
    {
        Debug.Log("Attack Masuk");
        ninjaController.animator.SetTrigger("isAttacking");
    }

    public override void Exit()
    {
        ninjaController.attacking = false;
        Debug.Log("Attack Keluar");
    }
}


