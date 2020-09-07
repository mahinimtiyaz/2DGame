using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDropSound : MonoBehaviour
{
    public static AudioClip bombDrop;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        bombDrop = Resources.Load<AudioClip>("bombDrop");
        audioSrc = GetComponent<AudioSource>();
    }

    public static void playSound()
    {
        audioSrc.PlayOneShot(bombDrop);
    }
}
