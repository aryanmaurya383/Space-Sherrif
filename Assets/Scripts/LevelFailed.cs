using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class LevelFailed : MonoBehaviour
{

    public Button FinishButton;
    public TextMeshProUGUI levelStatus;

    // Start is called before the first frame update
    void Start()
    {
        levelStatus.text = "Level Cleared";
        FinishButton.GetComponent<CanvasGroup>().alpha = 1; // or 1 to show
        FinishButton.interactable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (LevelCleared.currentLevelNumber == 5)
        {
            if (!LevelCleared.levelFailed)
            {
                levelStatus.text = "Game Completed";
            }
            FinishButton.GetComponent<CanvasGroup>().alpha = 0; // or 1 to show
            FinishButton.interactable = false;
        }
        if (LevelCleared.levelFailed)
        {
            levelStatus.text = "Level Failed";
            Enemy.enemiesDied = 0;
            ScoreCounter.scoreValue = 0;
            
            
            LevelCleared.levelFailed=false;
            
            FinishButton.GetComponent<CanvasGroup>().alpha = 0; // or 1 to show
            FinishButton.interactable = false;
        }
        

    }
}
