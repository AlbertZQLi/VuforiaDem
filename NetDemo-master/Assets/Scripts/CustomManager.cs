using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CustomManager : NetworkManager
{

  GameObject playerGO;
  bool playerFound = false;
  public override void OnStartHost()
  {
    Debug.Log("Host has started");
  }
  public override void OnStartServer()
  {
    Debug.Log("Server has started");
  }
  public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
  { 

    var player = (GameObject)Instantiate(base.playerPrefab, new Vector3(0f, 0f, 0f), Quaternion.identity);
    var ids = Object.FindObjectsOfType<NetworkIdentity>();
    playerGO = ClientScene.FindLocalObject(ids[1].netId);
    playerFound = true;



  }
  public void Update()
  {
    //if(playerFound == true)
    //Debug.Log(playerGO.transform.position);
  }


}
