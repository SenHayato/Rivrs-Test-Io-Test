using UnityEngine;
using UnityEngine.InputSystem;

public class InputActive : MonoBehaviour
{
    public static InputActive instance;
    [SerializeField] PlayerInput playerInput;
    [SerializeField] NinjaController ninjaController;

    public InputAction moveAction, attackAction, jumpAction;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        ninjaController = FindFirstObjectByType<NinjaController>();
        playerInput = GetComponent<PlayerInput>();
    }

    void Start()
    {
        moveAction = playerInput.actions.FindAction("Move");
        attackAction = playerInput.actions.FindAction("Attack");
        jumpAction = playerInput.actions.FindAction("Jump");
    }

     void PlayerMovement()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        moveValue.y = 0;
        ninjaController.moveInput = moveValue.x;
    }

    void PlayerJump()
    {
        if (jumpAction.triggered && !ninjaController.attacking)
        {
            ninjaController.jumping = true;
        }
    }

    void PlayerAttack()
    {
        if (attackAction.triggered && !ninjaController.jumping)
        {
            ninjaController.attacking = true;
        }
    }

    void Update()
    {
        if (!ninjaController.dying)
        {
            PlayerJump();
            PlayerMovement();
            PlayerAttack();
        }
    }
}
