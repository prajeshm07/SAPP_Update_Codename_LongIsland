using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeThemeScript : MonoBehaviour {

    public Texture [] m_MainTexture;
    Renderer m_Renderer;
    public bool flag;
    public int arrayLength,index = 0;
    // Use this for initialization
    void Start () {
        m_Renderer = GetComponent<Renderer>();
        m_Renderer.material.EnableKeyword("_ALBEDO");
        arrayLength = m_MainTexture.Length;
        m_Renderer.material.SetTexture("_MainTex", m_MainTexture[index]);
    }
	
	// Update is called once per frame
	void Update () {
        flag = Input.GetKeyDown("e");
        if(flag)
        {
            m_Renderer.material.SetTexture("_MainTex", m_MainTexture[index]);
            index++;
            if (index == arrayLength){
                index = 0;
            }
 
            flag = false;
        }
	}
}
