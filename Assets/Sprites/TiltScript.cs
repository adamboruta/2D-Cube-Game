using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltScript : MonoBehaviour
{
    [SerializeField]
    GameObject thingToTilt;
    [SerializeField]
    GameObject ball;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            //Vector3 newRotation = new Vector3(0, 0, 10);
            thingToTilt.transform.Rotate(new Vector3(0, 0, 10));
            ball.SetActive(true);
            GameObject.Destroy(this);
        }
    }
}
