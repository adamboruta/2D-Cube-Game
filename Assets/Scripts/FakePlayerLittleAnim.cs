using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakePlayerLittleAnim : MonoBehaviour
{
    public Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void bringName()
    {
        anim.SetBool("bringsName", true);
    }
}
    