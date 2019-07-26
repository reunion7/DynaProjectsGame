using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaJugador : MonoBehaviour
{
    public float minY = -10f;
    public GameObject FinJuego;
    private Animator animador;
    private Rigidbody2D rb2d;
	private SpriteRenderer spriteRenderer;
    public bool playerEnRango;

    void Start()
    {
        animador = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
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

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Enemy")
		{
			spriteRenderer.color = Color.white;
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
        if (GameSetter.gs.GetVidas() >= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
			FinJuego.SetActive(true);
		}

    }

}
