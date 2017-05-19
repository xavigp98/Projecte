using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Tesoro3Trigger : MonoBehaviour
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
            if (data.KeyExists("Tesoro3"))
                SceneManager.LoadScene("Nivel3Win");
            else
            {
                data.AddValue("Tesoro3", true);
                SceneManager.LoadScene("Nivel3Win");
            }
        }
    }
}
