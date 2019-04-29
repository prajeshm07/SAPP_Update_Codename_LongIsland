using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class player_animation : NetworkBehaviour {

    public Animator playerAnimator;
	
	// Update is called once per frame
	void Update () {
        CheckPlayerIp();

    }
void CheckPlayerIp()
    {
        if(!isLocalPlayer)
        {
            return;
        }
        if (Mathf.Abs(Input.GetAxis("Vertical")) > 0 || Mathf.Abs(Input.GetAxis("Horizontal")) > 0)
        {
            playerAnimator.SetBool("moving", true);
        }
        else
        {
            playerAnimator.SetBool("moving", false);
        }

    }
}

