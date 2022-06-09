using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public GameObject menuItems;
    Animator anim;


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        anim.SetTrigger("FadeInTrigger");
    }

    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
    public IEnumerator StartGame()
    {
        anim.SetTrigger("FadeOutTrigger");
        yield return new WaitForSeconds(2);
        
        yield return null;
    }
    
     public void CreditsAnimations()
    {
       
    }

    public void QuitGame()
    {
        Application.Quit();
    }
        

    
    
       
    

    
}
