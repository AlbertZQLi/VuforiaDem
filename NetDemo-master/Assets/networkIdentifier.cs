using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;

public class networkIdentifier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    NetworkInstanceId playerId = GetComponent<NetworkIdentity>().netId;

    Debug.Log("player id : " + playerId);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
