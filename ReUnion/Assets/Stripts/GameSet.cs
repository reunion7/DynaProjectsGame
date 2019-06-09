using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSet : MonoBehaviour {

    bool endGame = false;
    public float RestartTime = 1f;

    public void EndGame()
    {
        if (endGame == false)
        {
            endGame = true;
            Invoke("Restart", RestartTime);
        }
    }
    public void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void Restart()
    {
        SceneManager.LoadScene("Menu Muerte");
    }


}
