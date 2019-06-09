using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public int lives = 3;

    void FixedUpdate()
    {


        if (rb.position.y < -7.5f)
        {
            FindObjectOfType<GameSet>().Respawn();
            lives -= 1; 
        }
        if (lives <= 0)
        {
            FindObjectOfType<GameSet>().EndGame();
        }
        
    }

}
