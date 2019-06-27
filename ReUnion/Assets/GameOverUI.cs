using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{


    public void Salir()
    {
        Application.Quit();
    }
    public void Retry()
    {
		GameSetter.gs.Fin();
    }

	


}
