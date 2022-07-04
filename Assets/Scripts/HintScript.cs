using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintScript : MonoBehaviour
{
    private Animator anim;
    private bool shown;
    [SerializeField]
    GameObject instruction2;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && shown == false)
        {
            anim.Play("Arrow_anim");
        }
        shown = true;

        instruction2.SetActive(true);
    }

    

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            anim.Play("arrow_Fadeout");
        }
    }



}
