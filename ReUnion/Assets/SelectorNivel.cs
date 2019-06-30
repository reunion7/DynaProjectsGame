using UnityEngine;

public class SelectorNivel : MonoBehaviour
{

	public SceneFader fader;
	public void Seleccionar(string nombre)
	{
		fader.FadeTo(nombre);
	}
}
