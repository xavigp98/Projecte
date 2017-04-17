using UnityEngine;
using System.Collections;

public class Resolucion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Screen.SetResolution(1920, 1080, true);
	}
}
