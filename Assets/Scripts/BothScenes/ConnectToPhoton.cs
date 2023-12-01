using UnityEngine;
using Photon.Pun;

public class ConnectToPhoton : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {
        // Connect to the Photon server
        PhotonNetwork.ConnectUsingSettings();
    }

    // This function is called when the client is connected to the Master Server and ready for matchmaking
    public virtual void OnConnectedToMaster () {
        Debug.Log( "Connected to Photon Master Server" );
    }
}



