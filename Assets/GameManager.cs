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



    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GameOver");
            //Restart();
            //Invoke("Restart", 1);
            Restart();
        }
        

    }

    void Restart()
    {
        rocket.transform.position = RocketController.startPosition;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    
}
