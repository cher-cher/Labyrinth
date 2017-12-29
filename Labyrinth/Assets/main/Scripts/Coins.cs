using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Coins : MonoBehaviour {

    public GameObject character;
    public GameObject coin;
    private Text txt;
    private int gold = 0;

    // Use this for initialization
    void Start () {
        txt = GetComponent<Text>();
        txt.text = gold.ToString();
    }
	
	// Update is called once per frame
	void Update () {
    
		if (/*character.transform.position.x > 0.276f || */character.transform.position.x == coin.transform.position.x)
        {
            Debug.Log("lol");
            gold = gold + 1;
            txt.text = gold.ToString();
            Destroy(coin);
        }
        
    }
}
