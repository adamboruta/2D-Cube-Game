using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public GameObject player;

    public bool hasPoints = false;
    [SerializeField] TextMeshProUGUI scoreText;
    public static ScoreManager Instance { get; private set; }

    public float score { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public void IncreaseScore(float amount)
    {
        score += amount;
    }

    private void Update()
    {
        scoreText.text = score + "/3";

        if (score == 3)
        {
            hasPoints = true;
            //Instantiate(Yay, player.transform.position, Quaternion.identity);
        }
    }
    
    
   
}
