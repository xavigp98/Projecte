using UnityEngine;
using System.Collections;
using System;

public class MenuManager : MonoBehaviour {
    GameData data;
    public GameObject Tesoro1,Tesoro2,Tesoro3,Tesoro4,Tesoro5;
    // Use this for initialization
    void Start () {
        data = GameData.GetInstance();
        Tesoro1.GetComponent<SpriteRenderer>().enabled = false;
        Tesoro2.GetComponent<SpriteRenderer>().enabled = false;
        Tesoro3.GetComponent<SpriteRenderer>().enabled = false;
        Tesoro4.GetComponent<SpriteRenderer>().enabled =false;
        Tesoro5.GetComponent<SpriteRenderer>().enabled =false;
    }
	
	// Update is called once per frame
	void Update () {
	    if (data.KeyExists("Tesoro1"))
        {
            Tesoro1.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (data.KeyExists("Tesoro2"))
        {
            Tesoro2.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (data.KeyExists("Tesoro3"))
        {
            Tesoro3.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (data.KeyExists("Tesoro4"))
        {
            Tesoro4.GetComponent<SpriteRenderer>().enabled = true;
            Tesoro5.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
