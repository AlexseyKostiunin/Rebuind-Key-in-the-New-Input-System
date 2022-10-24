using UnityEngine;
using UnityEngine.InputSystem;

public class JumpControllerUnity : MonoBehaviour
{
    [SerializeField]
    private PlayerInput _playerInput;
    
    private RebindJumping gameActions;

    private Rigidbody rb;

    private void OnEnable()
    {
        gameActions = InputManager.inputActions;

        _playerInput.actions["Interact"].started += DoJump;

        rb = this.GetComponent<Rigidbody>();
    }

    private void DoJump(InputAction.CallbackContext obj)
    {
        rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }
}
