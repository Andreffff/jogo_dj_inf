using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTrigger : MonoBehaviour
{
    public ParticleSystem particles_collide;
    public GameManager gameManager;
    [SerializeField]
    GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Untagged" || collision.gameObject.tag == "NPC")
        {
            GameManager.gameOver = true;
            //player.transform.position = RocketController.startPosition;
            FindObjectOfType<GameManager>().GameOver();


        }

        if (collision.gameObject.tag == "Finish")
        {
            GameManager.levelWin = true;
            //player.transform.position = RocketController.startPosition;
            FindObjectOfType<GameManager>().LevelWin();


        }


    }
}
