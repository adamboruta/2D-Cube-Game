using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //Movement
    public float jumpForce;
    public float speed;
    public float shadowSpeed;
    bool facingRight;
    
    [SerializeField]
    Transform firePoint;
    [SerializeField]
    AudioSource collectibleSound;
    [SerializeField]
    AudioSource collectibleSound2;
    [SerializeField]
    AudioSource collectibleSound3;
    [SerializeField]
    AudioSource jumpSound;

    //Obiekty
    public GameObject CollectibleBreak;
    public GameObject particle;
    
    public GameObject playerShadow;
    private Rigidbody2D rb;

    public float gravityScale = 1;
    public float fallingGravityScale = 1.7f;

    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerShadow = GameObject.Find("PlayerShadow");
    }
    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

       // if(Input.GetAxis("Horizontal")>0)
       // {
       //     facingRight = true;
       // }
       // if(Input.GetAxis("Horizontal")<0)
       // {
       //     facingRight = false;
       //     transform.Rotate(0f, 180f, 0f);
       // }

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            spawnJumpParticle();
            jumpSound.Play();
        }
        
        //Szybsze spadanie
        if(rb.velocity.y >= 0)
        {
            rb.gravityScale = gravityScale;
        } else if (rb.velocity.y < 0)
        {
            rb.gravityScale = fallingGravityScale;
        }

        //Movement cienia
        if(movement>0)
        {
            
            playerShadow.transform.position = transform.position + new Vector3(-0.1f, 0.1f, 0) *shadowSpeed;
        }
        if(movement<0)
        {
            
            playerShadow.transform.position = transform.position + new Vector3(0.1f, 0.1f, 0);
        }

       

    }
    void spawnJumpParticle()
    {
        Instantiate(particle, transform.position, transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Collectible"))
        {
            if (ScoreManager.Instance.score == 0)
            {
                collectibleSound.Play();
            }
            if(ScoreManager.Instance.score == 1)
            {
                collectibleSound2.Play();
            }
            if(ScoreManager.Instance.score == 2)
            {
                collectibleSound3.Play();
            }

            Destroy(other.gameObject);
            ScoreManager.Instance.IncreaseScore(1);
            Instantiate(CollectibleBreak, other.transform.position, other.transform.rotation);
        }
    }

    public void CollectibeSounds()
    {
        
    }





}
