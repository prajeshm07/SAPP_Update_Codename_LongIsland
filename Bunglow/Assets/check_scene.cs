using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;


public class check_scene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SceneManager x;
		if (SceneManager.GetActiveScene().buildIndex==0)
        {
            XRSettings.enabled = false;

        }
        else
        {
            XRSettings.enabled = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
       
       /* if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("lobby");
        }*/
    }
}
