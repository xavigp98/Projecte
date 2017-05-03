using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Tesoro2Trigger : MonoBehaviour
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
            if (data.KeyExists("Tesoro2"))
                SceneManager.LoadScene("Nivel1Win");
            else
            {
                data.AddValue("Tesoro2", true);
                SceneManager.LoadScene("Nivel1Win");
            }
        }
    }
}
