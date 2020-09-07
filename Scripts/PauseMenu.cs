using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject Pausemenu, PauseButton;

    public void Pause()
    {
        ButtonClickSound.playSound();
        Pausemenu.SetActive(true);
        PauseButton.SetActive(false);
        Time.timeScale = 0;
    }
    public void Resume()
    {
        ButtonClickSound.playSound();
        Pausemenu.SetActive(false);
        PauseButton.SetActive(true);
        Time.timeScale = 1;
    }
    public void Pausedeactivate()
    {
        Pausemenu.SetActive(false);
    }

}
