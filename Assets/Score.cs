using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Score : MonoBehaviour
{
    public int score;
    public TMP_Text scoreCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
    }

    public void UpdateScore(int update)
    {
        score += update;
        scoreCounter.text = "Score: " + score;
    }
}
