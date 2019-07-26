using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaJugador : MonoBehaviour
{
    public float minY = -10f;
    public GameObject FinJuego;
    private Animator animador;
    private Rigidbody2D rb2d;
    public bool playerEnRango;

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
        if (playerEnRango)
        {
            perderVida();
            Reset();
        }
    }

    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.CompareTag("Enemy"))
        {
            playerEnRango = true;
        }

    }
    private void OnTriggerExit2D(Collider2D colision)
    {
        if (colision.CompareTag("Enemy"))
        {
            playerEnRango = false;
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
