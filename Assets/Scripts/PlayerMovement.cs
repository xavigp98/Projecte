using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour
{
    Animator animator;
    public float moveSpeed = 5f;
    public float jumpSpeed = 10f;
    private Rigidbody2D rb2d;
    public bool isGrounded = false;
    public int ammo = 0;
    public float maxtime = 0.5f;
    private float lastPlay;
    public int maxammo = 2;
    public GameObject emisor;
    public GameObject Bullet;
    public float fuerzaBullet;
    public int life = 2;
    public GameObject player;
    private float lastHit = 0f;
    private float maxHit = 0.5f;

    // Use this for initialization
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Start()
    {

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W) && isGrounded == true)
        {
            //animator.SetTrigger("Jump");
            rb2d.velocity = new Vector2(rb2d.velocity.x, 1 * jumpSpeed);
            isGrounded = false;
            lastPlay = Time.time;

        }


        if (Input.GetKey(KeyCode.W) && isGrounded == false && ammo < maxammo)
        {
            //animator.SetTrigger("Jump");
            if (Time.time - lastPlay > maxtime)
            {

                rb2d.velocity = new Vector2(rb2d.velocity.x, 1 * jumpSpeed);
                ammo++;
                lastPlay = Time.time;
                
                GameObject balaTemporal;
                balaTemporal= Instantiate(Bullet,emisor.transform.position, Quaternion.identity) as GameObject;
               
                Rigidbody2D rigidbodyTemporal;
                rigidbodyTemporal = balaTemporal.GetComponent<Rigidbody2D>();
                
                rigidbodyTemporal.velocity = new Vector2(0, -1 *fuerzaBullet);

                Destroy(balaTemporal, 0.2f);
            }
        }

        if (Input.GetKey(KeyCode.A) && isGrounded == true)
        {
            //animator.SetTrigger("walk");
            rb2d.velocity = new Vector2(-(1 * moveSpeed), 0);
        }


        if (Input.GetKey(KeyCode.D) && isGrounded == true)
        {
            // animator.SetTrigger("walk");
            rb2d.velocity = new Vector2((1 * moveSpeed), 0);
        }

        if (Input.GetKey(KeyCode.A) && isGrounded == false)
        {
            //animator.SetTrigger("walk");
            rb2d.velocity = new Vector2(-2, rb2d.velocity.y);
        }


        if (Input.GetKey(KeyCode.D) && isGrounded == false)
        {
            // animator.SetTrigger("walk");
            rb2d.velocity = new Vector2(2, rb2d.velocity.y);
        }
        if (life <= 0)
        {
            Destroy(player);
        }

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            //animator.SetTrigger("Jump");
            ammo = 1;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isGrounded = true;
            ammo = 0;
        }
        
        else if (collision.gameObject.tag == "Enemy" && Time.time - lastHit > maxHit)
        {
           
            life -= 1;
            lastHit = Time.time;
        }
        else if(collision.gameObject.tag == "Enemy2" && Time.time - lastHit > maxHit)
        {
            life -= 1;
            lastHit = Time.time;
        }
    }
}
