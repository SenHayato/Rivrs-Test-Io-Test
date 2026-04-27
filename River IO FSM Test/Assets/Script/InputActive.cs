using UnityEngine;
using UnityEngine.InputSystem;

public class InputActive : MonoBehaviour
{
    public static InputActive instance;
    [SerializeField] PlayerInput playerInput;

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

        playerInput = GetComponent<PlayerInput>();
    }

    void Start()
    {
        moveAction = playerInput.actions.FindAction("Move");
        attackAction = playerInput.actions.FindAction("Attack");
        jumpAction = playerInput.actions.FindAction("Jump");
    }

    //void Update()
    //{
    //    if (moveAction.triggered)
    //    {
    //        Debug.Log("Move Input");
    //    }

    //    if (attackAction.triggered)
    //    {
    //        Debug.Log("Attack Input");
    //    }

    //    if (jumpAction.triggered)
    //    {
    //        Debug.Log("Jump Input");
    //    }
    //}
}
