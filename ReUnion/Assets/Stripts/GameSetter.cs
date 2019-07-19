using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSetter : MonoBehaviour
{
	public static GameSetter gs;
	public int vidas = 4;
	void Awake()
	{
		if (gs == null)
		{
			gs = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}
	void Update()
	{

	}
	public void SetVidas(int vida)
	{
		if (vidas > -1)
		{
			vidas += vida;
		}
	}
	public int GetVidas()
	{
		return vidas;
	}
	public void Fin()
	{
		gs = null;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	public void GanarNivel()
	{
		Debug.Log("Gano Nivel!!");
	}
}
