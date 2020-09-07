using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickSound : MonoBehaviour
{
    public static AudioClip buttonClick;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        buttonClick = Resources.Load<AudioClip>("buttonClick");
        audioSrc = GetComponent<AudioSource>();
    }

    public static void playSound()
    {
        audioSrc.PlayOneShot(buttonClick);
    }
}
