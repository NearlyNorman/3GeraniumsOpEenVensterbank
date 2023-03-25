using UnityEngine;
using Photon.Realtime;
using Photon.Pun;
using UnityEngine.SceneManagement;
using System.Collections;

//
//This script connects to PHOTON servers and creates a room if there is none, then automatically joins
//
namespace Networking.Pun2
{
    public class NetworkManager : MonoBehaviourPunCallbacks
    {
        bool triesToConnectToMaster = false;
        bool triesToConnectToRoom = false;
        bool vrMode;
        bool gaze;
        bool english = false;

        private void Awake()
        {

            //Detects if running through a headset or not
            if (OVRPlugin.GetSystemHeadsetType() != OVRPlugin.SystemHeadset.None)
            {
                vrMode = true;
                Debug.Log("Headset detected, enabling vr mode");
            }
            else Debug.Log("Headset not detected, enabling desktop mode");

        }

        public void englishSelected()
        {
            english = true;
            Debug.Log("Engels!");
        }

        public void englishdeselected()
        {
            english = false;
            Debug.Log("Toch geen Engels!");
        }

        public void gazeSelected()
        {
            gaze = true;
            Debug.Log("Gaze is true");
        }

        public void gazeDeselected()
        {
            gaze = false;
            Debug.Log("Gaze is nie true");
        }

        private void Update()
        {
            if (!PhotonNetwork.IsConnected && !triesToConnectToMaster)
            {
                ConnectToMaster();
            }
            if (PhotonNetwork.IsConnected && !triesToConnectToMaster && !triesToConnectToRoom && gaze)
            {
                Debug.Log("Ale hup");
                StartCoroutine(WaitFrameAndConnect());
            }
        }

        public void ConnectToMaster()
        {
            PhotonNetwork.OfflineMode = false; //true would "fake" an online connection
            PhotonNetwork.NickName = "PlayerName"; //we can use a input to change this 
            PhotonNetwork.AutomaticallySyncScene = true; //To call PhotonNetwork.LoadLevel()
            PhotonNetwork.GameVersion = "v1"; //only people with the same game version can play together

            triesToConnectToMaster = true;
            //PhotonNetwork.ConnectToMaster(ip, port, appid); //manual connection
            PhotonNetwork.ConnectUsingSettings(); //automatic connection based on the config file
        }

        public override void OnDisconnected(DisconnectCause cause)
        {
            base.OnDisconnected(cause);
            triesToConnectToMaster = false;
            triesToConnectToRoom = false;
            Debug.Log(cause);
        }

        public override void OnConnectedToMaster()
        {
            base.OnConnectedToMaster();
            triesToConnectToMaster = false;
            Debug.Log("Connected to master!");
        }

        IEnumerator WaitFrameAndConnect()
        {
            triesToConnectToRoom = true;
            yield return new WaitForEndOfFrame();
            Debug.Log("Connecting");
            ConnectToRoom();
        }

        public void ConnectToRoom()
        {
            if (!PhotonNetwork.IsConnected)
                return;
            triesToConnectToRoom = true;

            if (!vrMode)
            {
                PhotonNetwork.CreateRoom("Geraniums", new RoomOptions { MaxPlayers = 14 }); //Create a specific room - Callback OnCreateRoomFailed

            }
            else
            {
                PhotonNetwork.JoinRoom("Geraniums"); //Join a specific room - Callback OnJoinRoomFailed
            }





            // PhotonNetwork.JoinRandomRoom(); // Join a random room - Callback OnJoinRandomRoomFailed
        }

        public override void OnJoinedRoom()
        {
            //Go to next scene after joining the room
            base.OnJoinedRoom();
            Debug.Log("Master: " + PhotonNetwork.IsMasterClient + " | Players In Room: " + PhotonNetwork.CurrentRoom.PlayerCount + " | RoomName: " + PhotonNetwork.CurrentRoom.Name + " Region: " + PhotonNetwork.CloudRegion);


            

            if (english == true)
            {
                 Debug.Log("Engelse versie opstarten");
                 SceneManager.LoadScene("Photon2RoomEnglish"); //go to the room scene
            }

            else if (english == false)
            {
                 Debug.Log("Nederlandse versie opstarten");
                 SceneManager.LoadScene("Photon2RoomDutch"); //go to the room scene
            }

         }

        public override void OnJoinRandomFailed(short returnCode, string message)
        {
            base.OnJoinRandomFailed(returnCode, message);
            //no room available
            //create a room (null as a name means "does not matter")
            //PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = 14 });
        }
    }
}