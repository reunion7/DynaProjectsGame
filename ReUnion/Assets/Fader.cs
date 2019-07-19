using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fader : MonoBehaviour
{
	public Image imagen;
	public AnimationCurve curva; //Esto permite configurar el fade de mi cambio de escena

	void Start()
	{
		StartCoroutine(FadeIn()); 
	}

	public void FadeTo(string nombreEscena)
	{
		StartCoroutine(FadeOut(nombreEscena));
	}

	IEnumerator FadeIn()
	{
		float tiempo = 1f;

		while (tiempo > 0f)
		{
			tiempo -= Time.deltaTime;
			float aux = curva.Evaluate(tiempo); 
			imagen.color = new Color(0f, 0f, 0f,aux);
			yield return 0; //Espera al siguiente frame para seguir en el while
		}
	}
	IEnumerator FadeOut(string nombreEscena)
	{
		float tiempo = 0f;

		while (tiempo < 1f)
		{
			tiempo += Time.deltaTime;
			float aux = curva.Evaluate(tiempo);
			imagen.color = new Color(0f, 0f, 0f, aux);
			yield return 0; //Espera al siguiente frame para seguir en el while
		}
		SceneManager.LoadScene(nombreEscena);
	}
}
