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

    public override void OnStartClient(NetworkClient client)
    {
        Debug.Log("MyNetworkManager.OnStartClient at " + Time.timeSinceLevelLoad);
        InvokeRepeating("PrintDots", 0f, 1f);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log("MyNetworkManager.OnClientConnect at " + Time.timeSinceLevelLoad + " address="+conn.address);
        CancelInvoke();
    }

    void PrintDots()
    {
        Debug.Log(".");
    }
}
