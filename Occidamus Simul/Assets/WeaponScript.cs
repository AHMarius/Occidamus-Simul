using UnityEngine;
using Photon.Pun;
using Vector2 = UnityEngine.Vector2;

public class WeaponScript : MonoBehaviour
{
    private PhotonView _viewPhoton;
    private GameObject _weaponObject;
    private Transform _weaponTransform;
    private Vector2 _playerPosition;
    private Vector2 _mousePosition;
    private float _rotationAngle;

    private void Start()
    {
        _weaponObject = transform.GetChild(0).gameObject;
        _weaponTransform = _weaponObject.transform;
        _viewPhoton = GetComponent<PhotonView>();
    }

    private void Update()
    {
        if (_viewPhoton.IsMine)
        {
            var position = Camera.main.WorldToViewportPoint(transform.position);
            _playerPosition = new Vector2(position.x, position.y);
            _mousePosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            _rotationAngle =
                Mathf.Atan2(
                    -(_playerPosition.y - _mousePosition.y),
                    -(_playerPosition.x - _mousePosition.x)
                ) * Mathf.Rad2Deg;
        }
    }

    private void FixedUpdate()
    {
        _weaponTransform.eulerAngles = new Vector3(0, 0, _rotationAngle);
    }
}
