using UnityEngine;
using Photon.Pun;

public class PlayerInputScript : MonoBehaviour
{
    public Transform attackPoint;
    private float _movementSpeed;
    private Rigidbody2D _rbPlayer;
    private Vector2 _movementInput;
    private PhotonView _viewPhoton;
    private PlayerDataScript _playerData;

    private void Start()
    {
        _playerData = GetComponent<PlayerDataScript>();
        _rbPlayer = this.GetComponent<Rigidbody2D>();
        _viewPhoton = GetComponent<PhotonView>();
        _movementSpeed = _playerData.playerMovementSpeed;
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
                    .Attack(attackPoint, _playerData.playerAttackRange, _playerData.playerDamage);
            }
        }
    }

    private void FixedUpdate()
    {
        _rbPlayer.MovePosition(
            _rbPlayer.position + _movementInput.normalized * (_movementSpeed * Time.fixedDeltaTime)
        );
    }
}
