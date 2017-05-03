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
   /* void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (data.GetLlave(0) == true)
                gameObject.SetActive(false);
        }
    }*/

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (data.GetLlave(0))
                gameObject.SetActive(false);
        }
    }
}
