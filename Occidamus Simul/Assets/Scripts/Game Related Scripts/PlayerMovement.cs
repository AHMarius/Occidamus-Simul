using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    private Rigidbody2D _rbPlayer;
    private Vector2 _movementInput;
    private PhotonView _viewPhoton;

    private void Start()
    {
        _rbPlayer = this.GetComponent<Rigidbody2D>();
        _viewPhoton = GetComponent<PhotonView>();
    }

    private void Update()
    {
        if (_viewPhoton.IsMine)
        {
            _movementInput.x = Input.GetAxisRaw("Horizontal");
            _movementInput.y = Input.GetAxisRaw("Vertical");
        }
    }

    private void FixedUpdate()
    {
        _rbPlayer.MovePosition(
            _rbPlayer.position + _movementInput.normalized * (movementSpeed * Time.fixedDeltaTime)
        );
    }
}
