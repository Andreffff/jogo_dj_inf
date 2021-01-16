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

    void Restart()
    {
        //rocket.transform.position = RocketController.startPosition;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    
}
