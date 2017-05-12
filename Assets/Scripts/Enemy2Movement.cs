using UnityEngine;
using System.Collections;


public class Enemy2Movement : MonoBehaviour
{
    public bool alive = true;
    private bool dirRight = true;
    float primeraPosicionx,primeraPosiciony;
    public float speed = 1.0f;
    public float dist;
   
    public SpriteRenderer enemigo2;
    public GameObject enemy2;

    private void Start()
    {
        primeraPosicionx = enemy2.transform.position.x;
        primeraPosiciony = enemy2.transform.position.y;
    }

    void Update()
    {
        if (!alive)
        {
            Destroy(enemy2);
        }
       
            if (dirRight)
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            else
                transform.Translate(-Vector2.right * speed * Time.deltaTime);

            if (Mathf.Abs(transform.position.x-primeraPosicionx) >= dist)
            {
                dirRight = !dirRight;
            }

             
    }
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            //animator.SetTrigger("Die");
            Destroy(enemy2);

        }

    }
    private void OnCollisionEnter3D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            alive = false;
        }
    }
}
