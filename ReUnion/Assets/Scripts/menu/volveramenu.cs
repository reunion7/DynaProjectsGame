using UnityEngine;

public class volveramenu : MonoBehaviour
{
	public Fader fader;

    public void Volver()
    {
		fader.FadeTo("Menu");
    }
}

