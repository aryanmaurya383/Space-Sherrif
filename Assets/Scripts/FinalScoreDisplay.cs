using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class FinalScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI score;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score " + ((int)ScoreCounter.finalScoreValue).ToString();

        
    }
}
