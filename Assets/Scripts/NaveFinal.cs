using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NaveFinal : MonoBehaviour
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
            if (data.KeyExists("Tesoro4"))
                SceneManager.LoadScene("Nivel4Win");
            else
            {
                data.AddValue("Tesoro4", true);
                SceneManager.LoadScene("Nivel4Win");
            }
        }
    }
}