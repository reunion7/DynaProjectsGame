using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverUI : MonoBehaviour
{

    public void Salir()
    {
        Debug.Log("app salir");
        Application.Quit();
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }



}
