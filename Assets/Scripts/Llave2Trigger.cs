using UnityEngine;
using System.Collections;

public class Llave2Trigger : MonoBehaviour {

    GameData data;
    void Start()
    {
        data = GameData.GetInstance();
        data.AddLlave(1, false);
    }

    void Update()
    {

    }
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            data.AddLlave(1, true);
            gameObject.SetActive(false);
        }
    }
}
