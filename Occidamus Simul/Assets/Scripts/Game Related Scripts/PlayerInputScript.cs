using UnityEngine;
using Photon.Pun;
using UnityEngine.UIElements;

public class PlayerInputScript : MonoBehaviour
{
    [SerializeField]
    private Transform attackPoint;
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
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GetComponent<PlayerCombatScript>()
                    .Attack(attackPoint, GetComponent<PlayerDataScript>().playerAttackRange);
            }
        }
    }

    private void FixedUpdate()
    {
        _rbPlayer.MovePosition(
            _rbPlayer.position + _movementInput.normalized * (movementSpeed * Time.fixedDeltaTime)
        );
    }
}
