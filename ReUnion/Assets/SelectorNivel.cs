using UnityEngine;

public class SelectorNivel : MonoBehaviour
{
	public Fader fader;

	public void Seleccionar(string nombre)
	{
		fader.FadeTo(nombre);
	}

	public void VolverMenuP()
	{
		fader.FadeTo("Menu");
	}
}
