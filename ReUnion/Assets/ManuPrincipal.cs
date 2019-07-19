using UnityEngine;

public class ManuPrincipal : MonoBehaviour
{
	public Fader fader;

	public void Jugar()
	{
		fader.FadeTo("SelecNivel");
	}

	public void Opciones()
	{
		fader.FadeTo("Opciones");
	}

	public void Salir()
	{
		Application.Quit();
	}
}
