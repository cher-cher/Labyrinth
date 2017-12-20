using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFade : MonoBehaviour {

	private Text txt;
    
    public int t;
	
	void Start () {
        txt = GetComponent <Text> ();
	}
	
	void Update () {
		txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, Mathf.PingPong(Time.time / 1.5f, t));
	}
}
