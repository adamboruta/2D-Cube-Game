using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    Transform player;

    [SerializeField]
    SpriteRenderer sr;

    [SerializeField]
    float aggroRange;

    [SerializeField]
    float moveSpeed;

    Rigidbody2D rb;

    [SerializeField]
    GameObject alert;

    [SerializeField]
    AudioSource alertSound;

    [SerializeField]
    bool isChasing;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Zmienna zwracaj¹ca dystans miêdzy wrogiem, a graczem.
        float distToPlayer = Vector2.Distance(transform.position, player.position);
        
        if(distToPlayer < aggroRange)
        {
            sr.color = Color.red;
            ChasePlayer();
            isChasing = true;
        } 
        else
        {
            sr.color = new Color(1f, 0.5990566f, 0.9632367f, 1f);
            StopChasingPlayer();
            isChasing = false;
        }

        //playChaseSound();

        void ChasePlayer()
        {
            alert.SetActive(true);

            if (transform.position.x < player.position.x)
            {
                rb.velocity = new Vector2(moveSpeed, 0);
            }
            else
            {
                rb.velocity = new Vector2(-moveSpeed, 0);
            }
                     
        }

        void StopChasingPlayer()
        {
            alert.SetActive(false);
            rb.velocity = new Vector2(0, 0);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.gameObject.tag == "Player")
        {
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


    //void playChaseSound()
    //{
    //    if(isChasing == true)
    //    {
    //        alertSound.Play();
    //    } else
    //    {
    //        alertSound.Stop();
    //    }
    //}
}
