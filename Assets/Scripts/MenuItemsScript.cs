using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuItemsScript : MonoBehaviour
{
    public Animator anim;
    public FakePlayerLittleAnim fpla;


    private void Start()
    {
        
        anim = GetComponent<Animator>();
    }

    
    public void ToggleCredits(bool tog)
    {
        if (tog == true)
        {
            anim.SetBool("isCredits", true);
            fpla.bringName();
        }
        else
        {
            StartCoroutine(CloseCredits());
            fpla.anim.SetBool("bringsName", false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            StartCoroutine(CloseCredits());
            fpla.anim.SetBool("bringsName", false);
        }
    }

    public IEnumerator CloseCredits()
    {
        anim.SetBool("isCredits", false);
        yield return new WaitForSeconds(2);
        anim.SetTrigger("backToMenu");

        yield return null;
    }

    
}
