using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cc_move : MonoBehaviour {
	public CharacterController cc;
	public Transform vrcam;
	public float speed;
	public Renderer rend;
	bool pmove=true;
	Vector3 old;

	float h;
	float v;
	public RectTransform map;
	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();
		old = transform.position; 
	}
	
	// Update is called once per frame
	void Update () {
		getinput ();
		if (pmove == true) {
			if (v > 0) {
				Vector3 forward = vrcam.TransformDirection (Vector3.forward);
				cc.SimpleMove (forward * speed);
				/*if(old.x!=transform.position.x && old.z!=transform.position.z)
				{
					map.Translate (0,-0.00001f*speed,0f);
					old = transform.position;
				}*/
			} else if (v < 0) {
				Vector3 backward = vrcam.TransformDirection (Vector3.back);
				cc.SimpleMove (backward * speed);
				/*if(old.x!=transform.position.x && old.z!=transform.position.z)
				{
					map.Translate (0,0.00001f*speed,0f);
					old = transform.position;
				}*/
			} else if (h > 0) {
				Vector3 right = vrcam.TransformDirection (Vector3.right);
				cc.SimpleMove (right * speed);
				/*if(old.x!=transform.position.x  && old.z!=transform.position.z)
				{
					map.Translate (-0.00001f*speed,0f,0f);
					old = transform.position;
				}*/
			} else if (h < 0) {
				Vector3 left = vrcam.TransformDirection (Vector3.left);
				cc.SimpleMove (left * speed);
				/*if(old.x!=transform.position.x  && old.z!=transform.position.z)
				{
					map.Translate (0.00001f*speed,0f,0f);
					old = transform.position;
				}*/
			}
		}

		/*if (Input.GetButtonDown ("shootup")) {
			hitraycast (1);
		}	
		if (Input.GetButtonDown ("shootdown")) {
				
			hitraycast (2);
		}*/
	}
	void getinput()
	{
		v = Input.GetAxis ("Vertical");
		h = Input.GetAxis ("Horizontal");
	}/*
	void hitraycast (int x)
	{
		RaycastHit hitinfo;
		if (Physics.Raycast (vrcam.transform.position, vrcam.transform.forward, out hitinfo)) {
			change_color_wall_script s = hitinfo.transform.GetComponent<change_color_wall_script> ();
			if (s != null) {
				s.colorchange (x);
			} else if (s == null) {
				move_object_script g = hitinfo.transform.GetComponent<move_object_script> ();
				if (g != null && s == null) {
					if(pmove == true ){
						pmove = false;
						g.move ();
					}
					else if(pmove == false){
						pmove = true;
						g.stopmove ();
					}
				}
			}
		}

	}*/
}

