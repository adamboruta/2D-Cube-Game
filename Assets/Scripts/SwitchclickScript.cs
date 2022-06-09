using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchclickScript : MonoBehaviour
{
    [SerializeField]
    GameObject fan;

    [SerializeField]
    AudioSource switchSound;

    SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            sr.color = Color.green;
            fan.SetActive(true);
            switchSound.Play();
        }
    }
}
