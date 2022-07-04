using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingPlatformScript : MonoBehaviour
{
    private GameObject parent;
    private GameObject child1;
    private GameObject child2;

    void Start()
    {
        parent = this.gameObject;
        child1 = parent.transform.GetChild(0).gameObject;
        child2 = parent.transform.GetChild(1).gameObject;
        child2.SetActive(false);
    }

    private void Update()
    {
        StartCoroutine(Switcher());
    }
    void PlatformSwitcher()
    {
        if(child2.activeSelf)
        {
            child1.SetActive(true);
        }
        else
        {
            child1.SetActive(false);
        }
    }

    IEnumerator Switcher()
    {
        if(!child2.activeSelf)
        {
            yield return new WaitForSeconds(1);
            child2.SetActive(true);
            child1.SetActive(false);
        }
        else
        {
            yield return new WaitForSeconds(1);
            child2.SetActive(false);
            child1.SetActive(true);
        }
        
        
    }
}
