using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowScript : MonoBehaviour
{
    public Transform playerPostion;
    public float shadowSpeed;
    

    private void Start()
    {
        //transform.position = playerPosition +
    }

    void Update()
    {
        transform.position = playerPostion.position + new Vector3(-0.1f, 0.1f, 0);
        
    }
}
