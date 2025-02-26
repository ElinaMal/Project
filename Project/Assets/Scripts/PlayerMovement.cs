using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Skills
{
    public static class DoubleJump
    {
        [SerializeField] public static bool available;
    }

    public static class Climb
    {
        [SerializeField] public static bool available;
    }

    public static class Dash
    {
        [SerializeField] public static bool available;
    }
}

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float velocity;
    [SerializeField] private float jumpForce;
    [SerializeField] private bool isGrounded;
    private Rigidbody2D _rb;
    private Vector2 _moveAmount;
    private Vector2 jump;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        jump = new Vector2(_rb.linearVelocityX, _rb.linearVelocityY = jumpForce);
    }

    // Update is called once per frame
    void Update()
    {
        _rb.linearVelocityX = _moveAmount.x * velocity;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            velocity = 10;
        }
        else
        {
            velocity = 5;
        }

        /*
        if (Input.GetKey(KeyCode.A))
        {
            _rb.linearVelocityX = -velocity;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rb.linearVelocityX = velocity;
        }
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            _rb.AddForce(jump * 20);
            isGrounded = false;
        }
        */
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
        }
    }

    public void HandleMovement(InputAction.CallbackContext ctx)
    {
        _moveAmount = ctx.ReadValue<Vector2>();
    }

    public void HandleJump(InputAction.CallbackContext ctx)
    {
        if (isGrounded)
        {
            _rb.AddForce(jump * 20);
            isGrounded = false;
        }
    }
}
