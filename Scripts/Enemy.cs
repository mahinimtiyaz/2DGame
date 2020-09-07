using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float rotationSpeed;

    public GameObject dust;

    private void FixedUpdate()
    {
    transform.Rotate(0, 0, rotationSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            
            Destroy(collision.gameObject);
            Destroy(gameObject);
            GameManager.instance.GameOver();
        }

        else if (collision.gameObject.tag == "Ground")
        {
            BombDropSound.playSound();
            GameManager.instance.IncrementScore();
            GameObject dustEffect = Instantiate(dust, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
            Destroy(dustEffect,1f);
            Destroy(gameObject,2f); 
        }
    }

   
}
