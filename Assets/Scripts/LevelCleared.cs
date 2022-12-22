using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class LevelCleared : MonoBehaviour
{
    public static bool levelFailed;
    private int NoOfEnemiesLevel1 = 5;
    private int NoOfEnemiesLevel2 = 5;
    private int NoOfEnemiesLevel3 = 7;
    private int NoOfEnemiesLevel4 = 6;
    private int NoOfEnemiesLevel5 = 5;
    private int NoOfEnemiesCurrentLevel = 0;
    public static int currentLevelNumber = 0;
    public AudioSource levelClearedAudio;

    // Start is called before the first frame update
    void Start()
    {    
      
        levelFailed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            NoOfEnemiesCurrentLevel = NoOfEnemiesLevel1;
            currentLevelNumber = 1;
        }
        if (SceneManager.GetActiveScene().name == "Level2")
        {
            NoOfEnemiesCurrentLevel = NoOfEnemiesLevel2;
            currentLevelNumber = 2;

        }
        if (SceneManager.GetActiveScene().name == "Level3")
        {
            NoOfEnemiesCurrentLevel = NoOfEnemiesLevel3;
            currentLevelNumber = 3;

        }
        if (SceneManager.GetActiveScene().name == "Level4")
        {
            NoOfEnemiesCurrentLevel = NoOfEnemiesLevel4;
            currentLevelNumber = 4;

        }
        if (SceneManager.GetActiveScene().name == "Level5")
        {
            NoOfEnemiesCurrentLevel = NoOfEnemiesLevel5;
            currentLevelNumber = 5;

        }

        if(Shoot.numOfBulletsFired==5 && !Shoot.isBulletPresent)
        {
            if (Enemy.enemiesDied != NoOfEnemiesCurrentLevel)
            {
                levelFailed = true;
                
                SceneManager.LoadScene("LevelCleared");
            }
        }


        if (Enemy.enemiesDied == NoOfEnemiesCurrentLevel && !Shoot.isBulletPresent)
        {
            SceneManager.LoadScene("LevelCleared");
            Enemy.enemiesDied = 0;
            ScoreCounter.scoreValue = 0;
        }
    }
}
