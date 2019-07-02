using UnityEngine;
using UnityEngine.UI;

public class SelectorNivel : MonoBehaviour
{
	public Fader fader;
	public Button [] botonesNiveles;

	void Start()
	{
		int nivelAlcanzado = PlayerPrefs.GetInt("nivelAlcanzado",1); //falta configurar cuando se completa el nivel, script por crear


		for (int i = 0; i < botonesNiveles.Length; i++)
		{
			if(i + 1 > nivelAlcanzado)
			{
	 			botonesNiveles[i].interactable = false;
			}
		}
	}
	public void Seleccionar(string nombre)
	{
		fader.FadeTo(nombre);
	}

	public void VolverMenuP()
	{
		fader.FadeTo("Menu");
	}
}
