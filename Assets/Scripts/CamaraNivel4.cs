using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CamaraNivel4 : MonoBehaviour
{
    public GameObject player;
    public Text heart, bullet;
    private Vector2 offset,altura;
    GameData data;
    int ammo, maxammo, display, display2, maxvida;
    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
        data = GameData.GetInstance();
        altura = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        ammo = data.GetAmmo(0);
        maxammo = data.GetAmmo(1);
        maxvida = data.GetAmmo(2);
        display = maxammo - ammo;
        display2 = maxvida;
        transform.position = new Vector3(player.transform.position.x  + offset.x, altura.y,transform.position.z);
        heart.text = display2.ToString();
        bullet.text = display.ToString();
    }

}
