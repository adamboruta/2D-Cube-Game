using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelNameScript : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI tmpro;
    void Start()
    {
        string levelcount = SceneManager.GetActiveScene().name;
        tmpro.text = levelcount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
