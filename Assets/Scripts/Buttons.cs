using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Level" + (LevelCleared.currentLevelNumber + 1).ToString());
    }
    public void ReplayLevel()
    {
        SceneManager.LoadScene("Level" + (LevelCleared.currentLevelNumber).ToString());

    }
    public void Home()
    {
        SceneManager.LoadScene("Home");

    }
}
