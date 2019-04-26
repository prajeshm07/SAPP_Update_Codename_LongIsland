using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class cc_mov : NetworkBehaviour {
	CharacterController cc;
    public GameObject camobject;
	public Transform vrcam;
	public float speed;
	bool pmove=true;
	Vector3 old;

	public float h, v;
	public RectTransform map;
    // Use this for initialization
    void Start()
    {
        if (isLocalPlayer == true)
        {
            cc = GetComponent<CharacterController>();
            old = transform.position;
            camobject.GetComponent<Camera>().enabled = true;
            
        }
        else
        {

            camobject.GetComponent<Camera>().enabled = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (isLocalPlayer == true) { 
		getinput ();
		if (pmove == true) {
			if (v > 0) {
				Vector3 forward = vrcam.TransformDirection (Vector3.forward);
				cc.SimpleMove (forward * speed);
				
			} else if (v < 0) {
				Vector3 backward = vrcam.TransformDirection (Vector3.back);
				cc.SimpleMove (backward * speed);
				
			} else if (h > 0) {
				Vector3 right = vrcam.TransformDirection (Vector3.right);
				cc.SimpleMove (right * speed);
				
			} else if (h < 0) {
				Vector3 left = vrcam.TransformDirection (Vector3.left);
				cc.SimpleMove (left * speed);
				
			}
		}

            
        }
    }
    void getinput()
	{
		v = Input.GetAxis ("Vertical");
		h = Input.GetAxis ("Horizontal");
 	}
}

