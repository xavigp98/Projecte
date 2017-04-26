using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;
    GameData data;
    int ammo, maxammo, display,display2,maxvida;
    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
        data = GameData.GetInstance();
    }
	
	// Update is called once per frame
	void LateUpdate () {
        ammo = data.GetAmmo(0);
        maxammo = data.GetAmmo(1);
        maxvida = data.GetAmmo(2);
        display = maxammo - ammo;
        display2 = maxvida + 1;
        transform.position = player.transform.position + offset;
	}
    void OnGUI()
    {
        GUI.Label(new Rect(22, 50, 1600, 240),display.ToString());
        GUI.Label(new Rect(800, 50, 1600, 240), display2.ToString());
    }
}
