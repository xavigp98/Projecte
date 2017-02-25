using UnityEngine;
using System.Collections;


public class PlayerController: MonoBehaviour
{
    Animator animator;
    public float moveSpeed = 5f;
    public float jumpSpeed = 10f;
    private Rigidbody2D rb2d;
    public bool isGrounded = false;
    public int ammo = 0;
    public float maxtime = 0.5f;
    private float lastPlay;

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
        if (Input.GetKey(KeyCode.W) && isGrounded == false && ammo < 2)
        {
            //animator.SetTrigger("Jump");
            if (Time.time - lastPlay > maxtime)
            {

                rb2d.velocity = new Vector2(rb2d.velocity.x, 1 * jumpSpeed);
                ammo++;
                lastPlay = Time.time;
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
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        ammo = 0;
    }
}
