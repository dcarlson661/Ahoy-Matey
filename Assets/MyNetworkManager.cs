using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {


    public void MyStartHost()
    {
        Debug.Log("MyNetworkManager.MyStartHost at " + Time.timeSinceLevelLoad);
        StartHost();
    }

    public override void OnStartHost()
    {
        Debug.Log("MyNetworkManager.OnStartHost at " + Time.timeSinceLevelLoad);
    }

}
