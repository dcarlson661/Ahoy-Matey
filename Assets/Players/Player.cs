using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;
using System.Collections;

public class Player : NetworkBehaviour {

    private Vector3 inputValue;

	// Use this for initialization
	void Start () {
	
	}

    public override void OnStartLocalPlayer()
    {
        //Ok so in ue the camera of the prefab is disabled (unchecked)
        //and here each local player's camera is enabled
        // so we only have one camera on each machine
        GetComponentInChildren<Camera>().enabled = true;
    }
	
	// Update is called once per frame
	void Update () {

        if (!isLocalPlayer)
        {
            return;
        }
        inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal");
        inputValue.y = 0f;
        inputValue.z = CrossPlatformInputManager.GetAxis("Vertical");

        transform.Translate(inputValue);
    }
}
