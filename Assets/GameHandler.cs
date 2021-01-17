using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    public Text CoinText;
    public int totalCoins;
    public GameObject rocket;
    public Text scoreFinalText;

    public GameObject tutorialRightPanel;
    public GameObject tutorialLeftPanel;
    public GameObject LeftBtn;
    public GameObject RightBtn;



    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        CoinText.text = "Coins : " + totalCoins;
        scoreFinalText.text = "Score: " + totalCoins;
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

    public void DissapearBtnLeftTutorial()
    {
        LeftBtn.SetActive(false);
        tutorialLeftPanel.SetActive(false);
        
        
        
    }

    public void DissapearBtnRightTutorial()
    {
        RightBtn.SetActive(false);
        tutorialRightPanel.SetActive(false);

    }


}
