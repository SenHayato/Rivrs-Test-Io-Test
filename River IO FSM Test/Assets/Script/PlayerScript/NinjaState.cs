using UnityEngine;

public class NinjaState : MonoBehaviour
{
    public static NinjaState Instance;

    [Header("Ninja Status")]
    [SerializeField] PlayerState playerState;
    [SerializeField] float moveSpeed;

    [Header("Player Component")]
    [SerializeField] Animator animator;
    [SerializeField] CharacterController charController;

    [Header("Reference")]
    [SerializeField] InputActive inputActive;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

        inputActive = FindFirstObjectByType<InputActive>();
        animator = GetComponent<Animator>();
        charController = GetComponent<CharacterController>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerState = PlayerState.Idle;
    }

    void StateMachine()
    {
        switch (playerState)
        {
            case PlayerState.Attack:
                break;
            case PlayerState.Run:
                break;
            case PlayerState.Idle:
                break;
            case PlayerState.Jump:
                break;
            case PlayerState.Hurt:
                break;
            case PlayerState.Die:
                break;
        }
    }

    bool wasRunning = false;
    void InputHandler()
    {
        if (inputActive.attackAction.triggered)
        {
            playerState = PlayerState.Attack;
        }
        else if (inputActive.jumpAction.triggered)
        {
            playerState = PlayerState.Jump;
        }
        else if (!wasRunning)
        {

        }
        else
        {
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        InputHandler();
        StateMachine();
    }

    public enum PlayerState
    {
        Idle, Run, Jump, Attack, Hurt, Die
    }
}
