using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyPlayerController : NetworkBehaviour {

    public float playerSpeed = 2;

    private Vector3 inputValue;
    private Camera camera;
    
    // Use this for initialization 
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer) {
            return;
        }

        inputValue.x = Input.GetAxis("Horizontal");
        inputValue.y = 0f;
        inputValue.z = Input.GetAxis("Vertical");

        transform.Translate(inputValue);
    }

    public override void OnStartLocalPlayer()
    {
        GetComponentInChildren<Camera>().enabled = true;
    }
}
