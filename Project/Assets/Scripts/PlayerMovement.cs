using Unity.VisualScripting;
using UnityEngine;

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

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float velocity;
    [SerializeField] private float jumpForce;
    [SerializeField] private bool isGrounded;
    private Rigidbody2D _rb;
    private Vector2 jump;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

        jump = new Vector2(_rb.linearVelocityX, _rb.linearVelocityY = jumpForce);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            velocity = 10;
        }
        else
        {
            velocity = 5;
        }

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
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
        }
    }
}
