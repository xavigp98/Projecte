using UnityEngine;
using System.Collections;

public class Puerta3Trigger : MonoBehaviour {
    GameData data;
    void Start()
    {
        data = GameData.GetInstance();
    }

    void Update()
    {

    }
    // Use this for initialization
    /*  void OnTriggerEnter2D(Collider2D other)
      {
          if (other.tag == "Player")
          {
              if (data.GetLlave(1))
                  gameObject.SetActive(false);
          }
      }*/

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (data.GetLlave(2))
                gameObject.SetActive(false);
        }
    }
}
