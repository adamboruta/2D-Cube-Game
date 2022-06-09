using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSoundScript : MonoBehaviour
{

    [SerializeField]
    AudioSource selectSound;
    [SerializeField]
    AudioSource selectedSound;

    
    public void playSelectSound()
    {
        selectSound.Play();
    }

    public void playSelecteSound()
    {
        selectedSound.Play();
    }    

}
