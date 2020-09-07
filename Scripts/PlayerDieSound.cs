using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDieSound : MonoBehaviour
{
    public static AudioClip playerDie;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        playerDie = Resources.Load<AudioClip>("playerDie");
        audioSrc = GetComponent<AudioSource>();
    }

    public static void playSound()
    {
        audioSrc.PlayOneShot(playerDie);
    }
}
