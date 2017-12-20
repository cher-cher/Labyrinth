using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DetectedClick : MonoBehaviour
{
    public Text playTxt;
    public string level;

    private bool clicked;

    //void OnMouseDown()
    //{
    //    if (!clicked)
    //    {
    //        clicked = true;
    //        SceneManager.LoadScene(level);
    //    }
    //}

    void Update()
    {
        foreach(Touch t in Input.touches)
		{
			if(t.phase == TouchPhase.Began)
			{
				clicked = true;
				SceneManager.LoadScene(level);
			} 
		}
    }
}
