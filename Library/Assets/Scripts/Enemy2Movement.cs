using UnityEngine;
using System.Collections;

public class Enemy2Movement : MonoBehaviour
{
    public bool alive = true;
    private bool dirRight = true;
    public float speed = 1.0f;
    private Rigidbody2D RigidEnemy2;
    public SpriteRenderer enemigo2;
    public GameObject enemy2;

    private void Start()
    {
        RigidEnemy2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!alive)
        {
            Destroy(enemy2);
        }
        else if (enemigo2.isVisible)
        {
            if (dirRight)
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            else
                transform.Translate(-Vector2.right * speed * Time.deltaTime);

            if (transform.position.x >= 3.0f)
            {
                dirRight = false;
            }

            if (transform.position.x <= -3)
            {
                dirRight = true;
            }
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
