using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
    static MusicPlayer instance = null; 
    // Use this for initialization
    void Start () {
        if (null != instance)
        {
            Destroy(gameObject);
            //print("duplicate music player object, self destructing.");
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }

    }
	
}
