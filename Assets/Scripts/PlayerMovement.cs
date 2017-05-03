using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
   // Animator animator;
    public float moveSpeed = 5f;
    public float jumpSpeed = 7f;
    public float velAire = 10f;
    public float reboteHurt = 0.5f;
    private Rigidbody2D rb2d;
    public bool isGrounded = false;
    public int ammo = 0;
    public float maxvel = 6.5f;
    public float maxtime = 0.4f;
    private float lastPlay;
    private int lastKey = 0;
    public int maxammo = 2;
    public GameObject emisor;
    public GameObject Bullet;
    public float fuerzaBullet;
    public int life = 2;
    public GameObject player;
    private float lastHit = 0f;
    private float maxHit = 0.5f;
    GameData data;
    public GameObject currentcheckpoint;
    int maxvida = 2;
    // Use this for initialization
    private void Awake()
    {
       
        rb2d = GetComponent<Rigidbody2D>();
        data = GameData.GetInstance();
    }
    void Start()
    {
        data.AddLlave(0, false);
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
        if (Input.GetKey(KeyCode.Space) && isGrounded == true)
        {
            //animator.SetTrigger("Jump");
            rb2d.velocity = new Vector2(rb2d.velocity.x, 1 * jumpSpeed);
            isGrounded = false;
            lastPlay = Time.time;

        }
       
        if (Input.GetKey(KeyCode.Space) && isGrounded == false && ammo < maxammo)
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

                Destroy(balaTemporal, 0.3f);
            }
        }
        if(!Input.anyKeyDown && isGrounded == true)
        {
            rb2d.velocity = new Vector2(0.0f, 0.0f);
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
            if (lastKey == 2)
            {
                //animator.SetTrigger("walk");
                rb2d.AddForce(new Vector2(-velAire*6, 0));
                
            }
            else
            {
                //animator.SetTrigger("walk");
                rb2d.AddForce(new Vector2(-velAire, 0));
                if (rb2d.velocity.x < -maxvel)
                {
                    rb2d.velocity = new Vector2(-maxvel, rb2d.velocity.y);
                }
            }
            lastKey = 1;
        }


        if (Input.GetKey(KeyCode.D) && isGrounded == false)
        {
            // animator.SetTrigger("walk");
            if (lastKey == 1)
            {
                //animator.SetTrigger("walk");
                rb2d.AddForce(new Vector2(velAire * 6, 0));
            }
            rb2d.AddForce(new Vector2(velAire,0));
            if (rb2d.velocity.x > maxvel)
            {
                rb2d.velocity = new Vector2(maxvel,rb2d.velocity.y);
            }
            lastKey = 2;
        }
        if (life <= 0 && maxvida>0)
        {
            life = 1;
            maxvida--;
            transform.position = currentcheckpoint.transform.position;            
        }
        else if(life<=0 && maxvida<= 0)
        {
            maxvida = 3;
            SceneManager.LoadScene("GameOver");

        }

        data.AddMuni(0, ammo);
        data.AddMuni(1, maxammo);
        data.AddMuni(2, maxvida);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isGrounded = true;
            ammo = 0;
        }
        if (collision.gameObject.tag == "Bloque_Roto")
        {
            isGrounded = true;
            ammo = 0;
        }

       

        if (collision.gameObject.tag == "Puerta1")
        {
            if (data.GetLlave(0)){
                Destroy(collision);
            }
        }

        if (collision.gameObject.tag == "SaltoNivel1")
        {
            SceneManager.LoadScene("Nivel1");
        }


       
        if (collision.gameObject.tag == "Enemy")
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, reboteHurt * jumpSpeed );
            //animator.SetTrigger("Jump");
            ammo -= 1;
        }
        if (collision.gameObject.tag == "Pinchos")
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x,reboteHurt * jumpSpeed);
            //animator.SetTrigger("Hurt");
            life -= 1;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isGrounded = false;
        }
        if (collision.gameObject.tag == "Bloque_Roto")
        {
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && Time.time - lastHit > maxHit)
        {
            life -= 1;
            lastHit = Time.time;
        }
    }
}
