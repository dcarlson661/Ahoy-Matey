using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour {
    //http://gamedev.stackexchange.com/questions/104693/how-to-use-input-getaxismouse-x-y-to-rotate-the-camera
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    // Use this for initialization
    void Start () {
        Debug.Log("PlayerCameraStart ");
	}
	
	// Update is called once per frame
	void Update () {
        //yaw += speedH * Input.GetAxis("Mouse X");
        //pitch -= speedV * Input.GetAxis("Mouse Y");

        //Vector3 mousePosition = new Vector3(pitch, yaw, 0.0f);

        //transform.eulerAngles = mousePosition;// new Vector3(pitch, yaw, 0.0f);

        //http://stackoverflow.com/questions/28397558/rotate-camera-based-on-mouse-postitions-around-a-object-unity3d
        //transform.parent.transform.Rotate(mousePosition);

    }

    public void MoveCamera()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        Vector3 mousePosition = new Vector3(pitch, yaw, 0.0f);

        transform.eulerAngles = mousePosition;// new Vector3(pitch, yaw, 0.0f);
        //http://stackoverflow.com/questions/28397558/rotate-camera-based-on-mouse-postitions-around-a-object-unity3d
        //transform.parent.transform.Rotate(mousePosition);

    }
}
