using UnityEngine;
using System.Collections;

public class Enemi : MonoBehaviour {
    private Rigidbody2D rb2d;
    public GameObject enemy;
    public bool alive = true;
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
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            //animator.SetTrigger("Die");
            alive = false;

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
