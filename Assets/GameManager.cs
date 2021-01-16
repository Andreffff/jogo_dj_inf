using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour  
{
    bool gameHasEnded = false;

    [SerializeField]
    GameObject rocket;
    static Vector3 startPosition;

    public static bool gameOver;
    public GameObject gameOverPanel;
    public GameObject pausePanel;
    public GameObject PauseButton;

    public static bool isGamePaused = false;

    private void Start()
    {
        gameOver= false;
        Time.timeScale = 1;
    }


    public void GameOver()
    {
        if (gameOver)
        {
            gameHasEnded = true;
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            //Debug.Log("GameOver");
            //Restart();
        }
        

    }

    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
            PauseButton.SetActive(false);

        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            pausePanel.SetActive(false);
            PauseButton.SetActive(true);
        }
    }


    void Restart()
    {
        //rocket.transform.position = RocketController.startPosition;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    
}
