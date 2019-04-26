using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;
public class player_network : NetworkBehaviour {

   
    public GameObject[] characterModel;

    public override void OnStartLocalPlayer()
    {

        foreach(GameObject go in  characterModel)
        {
            go.SetActive(false);
        }
    }
}
