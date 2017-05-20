using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Tesoro4Trigger : MonoBehaviour
{
    public GameObject bloque1, bloque2, bloque3, bloque4,bola,bolaAparicion;
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
            {
                Destroy(bloque1);
                Destroy(bloque2);
                Destroy(bloque3);
                Destroy(bloque4);
                Instantiate(bola,bolaAparicion.transform.position,Quaternion.identity);
                Destroy(gameObject);
            }
            else
            {
                Destroy(bloque1);
                Destroy(bloque2);
                Destroy(bloque3);
                Destroy(bloque4);
                Instantiate(bola, bolaAparicion.transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
