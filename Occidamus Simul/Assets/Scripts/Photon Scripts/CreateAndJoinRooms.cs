using UnityEngine;
using TMPro;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public GameObject CreateInputField;
    public GameObject JoinInputField;

    public void CreateRoom()
    {
        string createRoomName = CreateInputField.GetComponent<TMP_InputField>().text;
        PhotonNetwork.CreateRoom(createRoomName);
    }

    public void JoinRoom()
    {
        string joinRoomName = JoinInputField.GetComponent<TMP_InputField>().text;
        PhotonNetwork.JoinRoom(joinRoomName);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("MainScene");
    }
}
