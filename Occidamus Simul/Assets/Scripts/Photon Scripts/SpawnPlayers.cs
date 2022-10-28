using UnityEngine;
using Photon.Pun;
using Quaternion = UnityEngine.Quaternion;
using Random = UnityEngine.Random;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public Vector2 minSpawnBoundaries;
    public Vector2 maxSpawnBoundaries;

    private void Start()
    {
        Vector2 randomPosition = new Vector2(
            Random.Range(minSpawnBoundaries.x, maxSpawnBoundaries.x),
            Random.Range(minSpawnBoundaries.y, maxSpawnBoundaries.y)
        );
        PhotonNetwork.Instantiate(
            playerPrefab.name,
            new Vector3(randomPosition.x, randomPosition.y, 0),
            Quaternion.identity
        );
    }
}
