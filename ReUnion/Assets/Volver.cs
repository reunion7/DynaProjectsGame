using UnityEngine;

public class Volver : MonoBehaviour
{
	public Fader fader;

	public void VolverMenuP()
	{
		fader.FadeTo("Menu");
	}
}

