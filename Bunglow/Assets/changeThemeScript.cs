using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeThemeScript : MonoBehaviour {

    public Texture m_MainTexture, m_Normal, m_Metal;
    Renderer m_Renderer;
    public bool flag;
    // Use this for initialization
    void Start () {
        m_Renderer = GetComponent<Renderer>();
        //Make sure to enable the Keywords
        m_Renderer.material.EnableKeyword("_ALBEDO");

       /* //Set the Texture you assign in the Inspector as the main texture (Or Albedo)
        m_Renderer.material.SetTexture("_MainTex", m_MainTexture);
        //Set the Normal map using the Texture you assign in the Inspector
        m_Renderer.material.SetTexture("_BumpMap", m_Normal);
        //Set the Metallic Texture as a Texture you assign in the Inspector
        m_Renderer.material.SetTexture("_MetallicGlossMap", m_Metal);*/
    }
	
	// Update is called once per frame
	void Update () {
        flag = Input.GetKeyDown("e");
        if(flag)
        {
            m_Renderer.material.SetTexture("_MainTex", m_MainTexture);
        }
	}
}
