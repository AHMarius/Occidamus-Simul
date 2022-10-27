using UnityEngine;
using Photon.Pun;
using Quaternion = UnityEngine.Quaternion;
using Random = UnityEngine.Random;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public Vector2 minSpawnBoundries;
    public Vector2 maxSpawnBoundries;

    private void Start()
    {
        Vector2 randomPosition = new Vector2(
            Random.Range(minSpawnBoundries.x, maxSpawnBoundries.x),
            Random.Range(minSpawnBoundries.y, maxSpawnBoundries.y)
        );
        PhotonNetwork.Instantiate(
            playerPrefab.name,
            new Vector3(randomPosition.x, randomPosition.y, 0),
            Quaternion.identity
        );
    }
}
