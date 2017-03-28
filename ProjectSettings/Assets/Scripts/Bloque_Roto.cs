using UnityEngine;
using System.Collections;

public class Bloque_Roto : MonoBehaviour
{
    public GameObject bloque;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(bloque, 0.5f);
        }
       
    }
}