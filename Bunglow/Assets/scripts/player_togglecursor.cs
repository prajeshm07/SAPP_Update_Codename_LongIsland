using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;

public class player_togglecursor : NetworkBehaviour {

    public GameObject cyb;// fpscontroller;
	// Update is called once per frame
	void Update () {
		if(!isLocalPlayer)
        {
            return;
        }
        //if(Input.GetButtonUp("Cancel"))
        {
         //   togglecursor();
        }
	}
    void togglecursor()
    {
        //cyb.SetActive(false);
        //fpscontroller.enabled = !fpscontroller.enabled;
    }
}
