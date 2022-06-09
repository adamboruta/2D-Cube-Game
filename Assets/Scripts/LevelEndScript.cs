using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEndScript : MonoBehaviour
{
    [SerializeField] GameObject darkScreen;
    [SerializeField] AudioSource levelEndSound;
    Animator anim;

    private void Start()
    {
       anim = GetComponent<Animator>();
    }
    private void Update()
    {
        //Obraca obiekt na osi Z
        //transform.Rotate(0, 0, 100 * Time.deltaTime); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && ScoreManager.Instance.hasPoints)
        {
            anim.SetTrigger("canExitTrigger");
            StartCoroutine(NextLevel());
        }

        if(collision.CompareTag("Player") && ScoreManager.Instance.hasPoints == false)
        {
            anim.SetTrigger("cannotExitTrigger");
        }
    }

    IEnumerator NextLevel()
    {
        levelEndSound.Play();
        darkScreen.GetComponent<Animator>().SetTrigger("FadeOutTrigger");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
