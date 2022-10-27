using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    private Rigidbody2D rbPlayer;
    private Vector2 movementInput;
    private PhotonView view;

    private void Start()
    {
        rbPlayer = this.GetComponent<Rigidbody2D>();
        view = GetComponent<PhotonView>();
    }

    private void Update()
    {
        if (view.IsMine)
        {
            movementInput.x = Input.GetAxisRaw("Horizontal");
            movementInput.y = Input.GetAxisRaw("Vertical");
        }
    }

    private void FixedUpdate()
    {
        rbPlayer.MovePosition(
            rbPlayer.position + movementInput.normalized * (movementSpeed * Time.fixedDeltaTime)
        );
    }
}
