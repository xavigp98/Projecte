using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;
    GameData data;
    int ammo, maxammo, display;
    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
        data = GameData.GetInstance();
    }
	
	// Update is called once per frame
	void LateUpdate () {
        ammo = data.GetAmmo(0);
        maxammo = data.GetAmmo(1);
        display = maxammo - ammo;
        transform.position = player.transform.position + offset;
	}
    void OnGUI()
    {
        GUI.Label(new Rect(22, 50, 1600, 240),display.ToString());
    }
}
