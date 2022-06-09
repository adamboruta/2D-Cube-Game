using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundboardScript : MonoBehaviour
{
    public AudioSource src1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")){
            src1.Play();
        }
    }

   


}
