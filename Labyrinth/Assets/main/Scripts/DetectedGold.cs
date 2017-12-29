using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectedGold : MonoBehaviour {

    public GameObject character;
    public GameObject gold;
    void Update()
    {
        Vector3 pos = character.transform.position;
        Vector3 posGold = gold.transform.position;
        Debug.Log("lol");
        if (pos.x == posGold.x)
        {
            Debug.Log("lol");
        }
    }
}
