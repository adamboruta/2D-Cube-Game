using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableSwitchScript : MonoBehaviour
{
    [SerializeField]
    GameObject switchclick;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            switchclick.SetActive(true);
        }
    }


}
