using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;
using System.Collections;

public class Player : NetworkBehaviour {

    private Vector3 inputValue;

    public float speedH = 2.0f;
    public float speedV = 2.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    // Use this for initialization
    void Start () {

        Debug.Log("Player Start ");
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

       

        yaw   += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        Vector3 mousePosition = new Vector3(/*pitch*/0.0f, yaw, 0.0f);
        transform.eulerAngles = mousePosition;// new Vector3(pitch, yaw, 0.0f);


    }
}
