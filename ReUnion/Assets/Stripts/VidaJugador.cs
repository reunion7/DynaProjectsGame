using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaJugador : MonoBehaviour
{
    public float minY = -10f;
	public GameObject FinJuego;
	private Animator animador;
    private Rigidbody2D rb2d;
	
    void Start()
    {
        animador = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (rb2d.position.y < minY)
        {
            perderVida();
            Reset();
        }

    }

    public void perderVida()
    {
        GameSetter.gs.SetVidas(-1);
    }

    public void Reset()
    {
        if(GameSetter.gs.GetVidas() >= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
		else
		{
			FinJuego.SetActive(true);
		}
		
    }

}
