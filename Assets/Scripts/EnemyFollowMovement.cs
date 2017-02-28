using UnityEngine;
using System.Collections;


public class EnemyFollowMovement : MonoBehaviour {

    public bool alive = true;
    public float maxSpeed = 0.03f;
    private Rigidbody2D rb2d;
    public  SpriteRenderer enemigo;
    public Transform player;
    public GameObject enemy;
    
 

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
       
	}

    

	// Update is called once per frame
	void Update () {
        
        if (!alive)
        {
            Destroy(enemy);
        }
        else if (enemigo.isVisible && Vector2.Distance(player.position,transform.position)>1)
        {
            transform.position = Vector2.MoveTowards(transform.position,player.position, maxSpeed);     
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            
            //animator.SetTrigger("Die");
            Destroy(enemy);
            
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            alive = false;
        }
    }
    
}
