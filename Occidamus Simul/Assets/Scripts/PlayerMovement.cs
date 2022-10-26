using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    private Rigidbody2D rbPlayer;
    private Vector2 movementInput;

    private void Start()
    {
        rbPlayer = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movementInput.x = Input.GetAxisRaw("Horizontal");
        movementInput.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rbPlayer.MovePosition(
            rbPlayer.position + movementInput.normalized * movementSpeed * Time.fixedDeltaTime
        );
    }
}
