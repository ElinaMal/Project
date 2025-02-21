using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float velocity;
    private Rigidbody2D _rb;
    [SerializeField] private float jumpForce;
    private Vector2 jump;
    private bool isGrounded;

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
            _rb.AddForce(jump * 4);
        }
    }
}
