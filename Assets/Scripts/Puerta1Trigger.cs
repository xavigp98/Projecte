using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Puerta1Trigger : MonoBehaviour
{
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
            if (data.GetLlave(0))
                Destroy(gameObject);
        }
    }
}
