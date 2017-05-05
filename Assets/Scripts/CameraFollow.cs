using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraFollow : MonoBehaviour {
    public GameObject player;
    public Text heart, bullet;
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
        display2 = maxvida;
        transform.position = player.transform.position + offset;
        heart.text = display2.ToString();
        bullet.text = display.ToString();
	}
    
}
