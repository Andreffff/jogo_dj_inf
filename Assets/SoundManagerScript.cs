using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip coin_15;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        coin_15 = Resources.Load<AudioClip>("coin_15");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound (string clip)
    {
        switch (clip)
        {
            case "coin_15":
                audioSrc.PlayOneShot(coin_15);
                break;
        }
    }
}
