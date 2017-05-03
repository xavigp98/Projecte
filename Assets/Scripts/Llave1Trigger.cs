using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Llave1Trigger : MonoBehaviour
{
    GameData data;
    void Start()
    {
        data = GameData.GetInstance();
        data.AddLlave(0, false);
    }

    void Update()
    {

    }
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            data.AddLlave(0, true);
            gameObject.SetActive(false);
        }
    }
}
