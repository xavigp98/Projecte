﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class TesoroTrigger : MonoBehaviour {
    GameData data;
    void Start()
    {
       data = GameData.GetInstance();
    }

    void Update()
    {

    }
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (data.KeyExists("Tesoro1"))
                SceneManager.LoadScene("Menu");
            else
            {
                data.AddValue("Tesoro1", true);
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
