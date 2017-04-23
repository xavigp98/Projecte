using UnityEngine;
using System.Collections;
using System;

public class MenuManager : MonoBehaviour {
    GameData data;
    public GameObject Tesoro1;
    // Use this for initialization
    void Start () {
        data = GameData.GetInstance();
        Tesoro1.GetComponent<SpriteRenderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
	    if (data.KeyExists("Tesoro1"))
        {
            Tesoro1.GetComponent<SpriteRenderer>().enabled = true;
        }
	}
}
