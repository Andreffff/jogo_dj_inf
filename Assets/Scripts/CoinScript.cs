using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameHandler GH;
    public AudioClip coinSound;
    public GameObject ParticlePrefab;

    // Start is called before the first frame update
    void Start()
    {
        GH = GameObject.Find("Canvas").GetComponent<GameHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<RocketController>().totalCoins++;
            GH.totalCoins++;
            Instantiate(ParticlePrefab, gameObject.transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(coinSound, transform.position);        
            //Add 1 to Points    
            Destroy(gameObject); //This destroys  coins
        }
       
    }
}
