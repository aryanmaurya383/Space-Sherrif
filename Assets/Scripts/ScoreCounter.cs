using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    
    public TextMeshProUGUI score;
    public static float scoreValue;
    public static float finalScoreValue;

    private void Start()
    {
        scoreValue = 0;
        finalScoreValue = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (scoreValue > finalScoreValue)
        {
            finalScoreValue = scoreValue;
        }

        score.text = "Score " + ((int)scoreValue).ToString();
    }
}
