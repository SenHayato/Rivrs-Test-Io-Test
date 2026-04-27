using PlayerStates;
using UnityEngine;

public class NinjaController : MonoBehaviour
{
    //Finite State Machine
    public NinjaFiniteStateMachine finiteStateMachine;

    //Ninja State
    public IdleState idleState;
    public RunState runState;
    public JumpState jumpState;
    public HurtState hurtState;
    public AttackState attackState;
    public DieState dieState;

    [Header("Player Status")]
    public float moveSpeed;
    public float moveInput;
    public bool jumping;

    [Header("Player Component")]
    [SerializeField] CharacterController characterController;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    [Header("Reference")]
    public InputActive inputActive;

    private void Awake()
    {
        finiteStateMachine = new NinjaFiniteStateMachine();

        idleState = new IdleState(this, finiteStateMachine);
        runState = new RunState(this, finiteStateMachine);
        jumpState = new JumpState(this, finiteStateMachine);
        hurtState = new HurtState(this, finiteStateMachine);
        attackState = new AttackState(this, finiteStateMachine);
        dieState = new DieState(this, finiteStateMachine);

        characterController = GetComponent<CharacterController>();
        inputActive = FindFirstObjectByType<InputActive>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        finiteStateMachine.Initialize(idleState);
    }

    // Update is called once per frame
    void Update()
    {
        finiteStateMachine.currentState.Update();
    }
}
