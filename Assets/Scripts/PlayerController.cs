using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody2D;

    private void Awake()
        => _rigidbody2D = GetComponent<Rigidbody2D>();

    private void Update()
    {
        Walk();

        Jump();
    }

    private void Walk()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        if (moveHorizontal != 0)
            _rigidbody2D.velocity = new Vector2(moveHorizontal * _speed, _rigidbody2D.velocity.y);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W))
            _rigidbody2D.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse);
    }
}