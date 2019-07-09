using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
	public Fader fader;

    public void Salir()
    {
		fader.FadeTo("Menu");
    }
    public void Reintentar()
    {
		GameSetter.gs.Fin();
    }

	


}
