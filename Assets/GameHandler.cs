using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    public TextMeshProUGUI CoinText;
    public int totalCoins;
    public GameObject rocket;



    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        CoinText.text = "Coins : " + totalCoins;
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameManager.gameOver = false;
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

    
}
