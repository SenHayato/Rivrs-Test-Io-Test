using PlayerStates;
using System.Collections;
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
    public bool attacking;
    public bool hurting;
    public bool dying;
    public bool grounded;

    [Header("Player Component")]
    //[SerializeField] CharacterController characterController;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D myRigidbody;

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

        //characterController = GetComponent<CharacterController>();
        inputActive = FindFirstObjectByType<InputActive>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        myRigidbody = GetComponent<Rigidbody2D>();
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

        if (Input.GetKeyDown(KeyCode.P))
        {
            Revive();
        }
    }

    #region BehaviorMethod
    private void OnCollisionEnter2D(Collision2D collision)
    {
        grounded = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("HurtTest"))
        {
            hurting = true;
        }
        else if (collision.CompareTag("DieTest"))
        {
            dying = true;
        }
    }

    void Revive()
    {
        dying = false;
        transform.position = new(0f, 0f);
        finiteStateMachine.ChangeState(idleState);
    }

    public void PlayerJump()
    {
        myRigidbody.linearVelocity = new(moveInput, 10f);
    }

    public void StopState() //Panggil di Animation
    {
        finiteStateMachine.ChangeState(idleState);
    }
    #endregion
}
