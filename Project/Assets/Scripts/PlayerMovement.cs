using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float velocity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2(-1,0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Vector2 up = new Vector2(0, 1) * velocity;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector2 right = new Vector2(1, 0) * velocity;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector2 down = new Vector2(0, -1) * velocity;
        }
    }
}
