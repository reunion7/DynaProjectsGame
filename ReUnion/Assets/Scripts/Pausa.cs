using UnityEngine;
using UnityEngine.EventSystems;

public class Pausa : MonoBehaviour
{
	public static bool pausa = false;
    public GameObject menuPausa;
	public Fader fader;

    public void Resumir()
    {
        menuPausa.SetActive(false);
        Time.timeScale = 1f;
        pausa = false;       
    }

    public void Pausar()
    {
        menuPausa.SetActive(true);
        Time.timeScale = 0f;
        pausa = true;
    }

	public void Ac()
	{
		if (pausa)
		{
			Resumir();
		}
		else
		{
			Pausar();
		}
	}

	void Update()
	{

	}

	public void VolverMenu()
	{
		Debug.Log("Volviendo al menu");
		Time.timeScale = 1f;
		fader.FadeTo("Menu");
	}



}
