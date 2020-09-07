using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTimer : MonoBehaviour
{

    public const float TIME_LIMIT = 2F;
    private float timer = 0F;

    void Update()
    {

        this.timer += Time.deltaTime;


        if (this.timer >= TIME_LIMIT)
        {
            SceneManager.LoadScene("Menu");
        }
    }

}